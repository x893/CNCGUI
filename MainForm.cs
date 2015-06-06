using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Threading;
using System.Globalization;

namespace CNCGUI
{
	public partial class MainForm : Form
	{
		private const int PLOT_X = 1000;
		private const int PLOT_Y = 1000;
		private const int LOG_QUEUE_SIZE = 1000;
		private const int GPLOT_QUEUE_SIZE = 1000;

		private const string CMD_RESPONSE_OK_mm = "tinyg [mm] ok>";
		private const string CMD_RESPONSE_OK_inch = "tinyg [inch] ok>";
		private const string CMD_RESPONSE_ERROR_mm = "tinyg [mm] err:";
		private const string CMD_RESPONSE_ERROR_inch = "tinyg [inch] err:";

		private bool m_setting_changed = false;
		private string RxBuffer;

		private ScanFormatted scanf = new ScanFormatted();
		private TinyG cnc = new TinyG();
		private Queue<ListViewItem> LogQueue = new Queue<ListViewItem>(LOG_QUEUE_SIZE);
		private Queue<GPoint> GPlotQueue = new Queue<GPoint>(GPLOT_QUEUE_SIZE);
		private Queue<string> Responses = new Queue<string>(200);
		private Graphics GPlotGraphics;
		private Pen GPlotPenP;
		private Pen GPlotPenM;
		private CultureInfo Culture = CultureInfo.InvariantCulture;

		private SizeF GPlotScale = new SizeF(5F, 5F);
		private GPoint GPlotCurrent = new GPoint(0.0F, 0.0F, 0.0F);
		private Bitmap GPlotBitmap = new Bitmap(PLOT_X, PLOT_Y);

		private bool m_auto_log = true;
		private bool m_log_invoke = false;

		private Color GCODE_CURRENT = Color.FromArgb(0, 192, 0);
		private Color GCODE_BREAKPOINT = Color.FromArgb(255, 192, 192);

		public MainForm()
		{
			InitializeComponent();

			System.Windows.Forms.Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
			AppDomain currentDomain = AppDomain.CurrentDomain;
			currentDomain.UnhandledException += new UnhandledExceptionEventHandler(Application_UnhandledException);

			disableControlsForPrinting();
			Stop_Btn.Enabled = false;
		}

		#region Exception handlers 
		private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
		{
			Exception ex = e.Exception;
			MessageBox.Show(ex.Message, "Thread exception");
		}

		private static void Application_UnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			if (e.ExceptionObject != null)
			{
				Exception ex = (Exception)e.ExceptionObject;
				MessageBox.Show(ex.Message, "Application exception");
			}
		}
		#endregion

		private void MainForm_Load(object sender, EventArgs e)
		{
			loadPortSelector();
			setPortCloseControls();

			GPlotPicture.Image = GPlotBitmap;
			GPlotGraphics = Graphics.FromImage(GPlotBitmap);
			GPlotPenM = new Pen(Color.White, 3F);
			GPlotPenP = new Pen(Color.DarkGray, 1F);

			MainForm_ResizeEnd(sender, e);
		}

		private void MainForm_ResizeEnd(object sender, EventArgs e)
		{
			LogColumn1.Width = Log.Width - SystemInformation.VerticalScrollBarWidth - Log.Margin.Left;
			columnGCode.Width = GCodes.Width - columnBP.Width - 2 * SystemInformation.BorderSize.Width - SystemInformation.VerticalScrollBarWidth - GCodes.Margin.Left;
			GPlotPicture.Scale(new SizeF((float)(GPlotPicture.Width / PLOT_X), (float)(GPlotPicture.Height / PLOT_Y)));
			GPlotPicture.Refresh();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				if (!ClosePort())
					e.Cancel = true;
				StopBtn_Click(sender, EventArgs.Empty);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#region Load_Btn_Click 
		private void Load_Btn_Click(object sender, EventArgs e)
		{
            openFileDialog.Filter = "G-code Files|*.cnc;*.nc;*.tap;*.txt;*.gcode;*.ngc|All files|*.*";
			openFileDialog.FileName = "";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				FileName.Text = openFileDialog.FileName;

				if (File.Exists(FileName.Text))
				{
					using (StreamReader r = new StreamReader(FileName.Text))
					{
						GCodes.Items.Clear();
						GCodes.CurrentLine = 0;
						GCodes.StopLine = -1;
						Debug_Btn.Enabled = false;
						string line = String.Empty;

						while ((line = r.ReadLine()) != null)
						{
							line = line.Trim();
							int i, j;
							while ((line.Length > 0) && (i = line.IndexOf('(')) >= 0)
							{
								j = line.IndexOf(')', i);
								line = string.Concat(
									(i > 0) ? line.Substring(0, i) : string.Empty,
									(j >= 0 && j + 1 < line.Length) ? line.Substring(j + 1) : string.Empty
									).Trim();
							}
							if (line.Length > 0)
							{
								GCodeListViewItem gcode = new GCodeListViewItem();
								gcode.SubItems.Add(new ListViewItem.ListViewSubItem(gcode, line));
								GCodes.Items.Add(gcode);
								if (gcode.Index == GCodes.CurrentLine)
								{
									GCodes.SavedLine = GCodes.CurrentLine;
									gcode.BackColor = GCODE_CURRENT;
								}
							}
						}
						if (GCodes.Items.Count > 0)
						{
							TabLogGraph.SelectedTab = PageGCode;
							Debug_Btn.Enabled = true;
						}

						RowsInFileLbl.Text = "Rows: " + GCodes.Items.Count.ToString();
						r.Close();
					}
				}

			}
		}
		#endregion

		#region SettingUnchange 
		private bool SettingUnchange()
		{
			if (m_setting_changed)
				if (MessageBox.Show("Configuration change. Lost all changes ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
					return false;
			return true;
		}
		#endregion

		#region RefreshBtn_Click 
		private void RefreshBtn_Click(object sender, EventArgs e)
		{
			if (SettingUnchange())
				GetCncState();
		}
		#endregion

		#region ParseSystemResponse 

		private void ParseSystemResponse(string line)
		{
			string key = line.Length >= 5 ? line.Substring(0, 5) : string.Empty;
			switch (key)
			{
				case "[fb] ":
					cnc.FirmwareBuild.Clear();
					if (scanf.Parse(line, "[fb] firmware build %d.%d") == 2
					&& scanf.Results.Count == 2)
					{
						cnc.FirmwareBuild.Major = (int)scanf.Results[0];
						cnc.FirmwareBuild.Minor = (int)scanf.Results[1];
					}
					break;

				case "[fv] ":
					cnc.FirmwareVersion.Clear();
					if (scanf.Parse(line, "[fv] firmware version %d.%d") == 2)
					{
						cnc.FirmwareVersion.Major = (int)scanf.Results[0];
						cnc.FirmwareVersion.Minor = (int)scanf.Results[1];
					}
					break;
				case "[hv] ":
					cnc.HardwareVersion.Clear();
					if (scanf.Parse(line, "[hv] hardware version %d.%d") == 2)
					{
						cnc.HardwareVersion.Major = (int)scanf.Results[0];
						cnc.HardwareVersion.Minor = (int)scanf.Results[1];
					}
					break;
				case "[id] ":
					cnc.ID = string.Empty;
					if (scanf.Parse(line, "[id] TinyG ID %s") == 1)
						cnc.ID = (string)scanf.Results[0];
					break;
				case "[ja] ":
					cnc.JunctionAcceleration.Default();
					if (scanf.Parse(line, "[ja] junction acceleration %d %s") >= 1)
						cnc.JunctionAcceleration.Set(scanf);
					break;
				case "[ct] ":
					cnc.ChordalTolerance.Default();
					if (scanf.Parse(line, "[ct] chordal tolerance %f %s") >= 1)
						cnc.ChordalTolerance.Set(scanf);
					break;
				case "[st] ":
					cnc.SwitchType.Value = SWITCH_TYPE.NormalOpen;
					if (scanf.Parse(line, "[st] switch type %d [%s]") >= 1)
						cnc.SwitchType.Set(scanf, UseResponseItems.Checked);
					break;
				case "[ej] ":
					cnc.JsonMode.Value = JSON_MODE.Text;
					if (scanf.Parse(line, "[ej] enable json mode %d [%s]") >= 1)
						cnc.JsonMode.Set(scanf, UseResponseItems.Checked);
					break;
				case "[jv] ":
					cnc.JsonVerbosity.Value = JSON_VERBOSITY.Linenum;
					if (scanf.Parse(line, "[jv] json verbosity %d [%s]") >= 1)
						cnc.JsonVerbosity.Set(scanf, UseResponseItems.Checked);
					break;
				case "[tv] ":
					cnc.TextVerbosity.Value = TEXT_VERBOSITY.Verbose;
					if (scanf.Parse(line, "[tv] text verbosity %d [%s]") >= 1)
						cnc.TextVerbosity.Set(scanf, UseResponseItems.Checked);
					break;
				case "[qv] ":
					cnc.QueueReportVerbosity.Value = REPORT_VERBOSITY.Filtered;
					if (scanf.Parse(line, "[qv] queue report verbosity %d [%s]") >= 1)
						cnc.QueueReportVerbosity.Set(scanf, UseResponseItems.Checked);
					break;
				case "[sv] ":
					cnc.StatusReportVerbosity.Value = REPORT_VERBOSITY.Filtered;
					if (scanf.Parse(line, "[sv] status report verbosity %d [%s]") >= 1)
						cnc.StatusReportVerbosity.Set(scanf, UseResponseItems.Checked);
					break;
				case "[si] ":
					cnc.StatusInterval = 100;
					if (scanf.Parse(line, "[si] status interval %d ms") == 1)
						cnc.StatusInterval = (int)scanf.Results[0];
					break;
				case "[ic] ":
					cnc.IgnoreCRLF.Value = IGNORE_CRLF.Off;
					if (scanf.Parse(line, "[ic] ignore CR or LF on RX %d [%s]") >= 1)
						cnc.IgnoreCRLF.Set(scanf, UseResponseItems.Checked);
					break;
				case "[ec] ":
					cnc.ExpandLF.Value = ON_OFF.Off;
					if (scanf.Parse(line, "[ec] expand LF to CRLF on TX %d [%s]") >= 1)
						cnc.ExpandLF.Set(scanf, UseResponseItems.Checked);
					break;
				case "[ee] ":
					cnc.EnableEcho.Value = ON_OFF.Off;
					if (scanf.Parse(line, "[ee] enable echo %d [%s]") >= 1)
						cnc.EnableEcho.Set(scanf, UseResponseItems.Checked);
					break;
				case "[ex] ":
					cnc.EnableXON.Value = ON_OFF.Off;
					if (scanf.Parse(line, "[ex] enable xon xoff %d [%s]") >= 1)
						cnc.EnableXON.Set(scanf, UseResponseItems.Checked);
					break;
				case "[gpl]":
					cnc.DefaultGcodePlane.Value = GCODE_PLANE.G17;
					if (scanf.Parse(line, "[gpl] default gcode plane %d [%s]") >= 1)
						cnc.DefaultGcodePlane.Set(scanf, UseResponseItems.Checked);
					break;
				case "[gun]":
					cnc.DefaultGcodeUnits.Value = GCODE_UNIT.G21;
					if (scanf.Parse(line, "[gun] default gcode units mode %d [%s]") >= 1)
						cnc.DefaultGcodeUnits.Set(scanf, UseResponseItems.Checked);
					break;
				case "[gco]":
					cnc.DefaultGcodeCoord.Value = GCODE_COORD.G54;
					if (scanf.Parse(line, "[gco] default gcode coord system %d") == 1)
						cnc.DefaultGcodeCoord.Set(scanf, false);
					break;
				case "[gpa]":
					cnc.DefaultGcodePath.Value = GCODE_PATH.G64;
					if (scanf.Parse(line, "[gpa] default gcode path control %d [%s]") >= 1)
						cnc.DefaultGcodePath.Set(scanf, UseResponseItems.Checked);
					break;
				case "[gdi]":
					cnc.DefaultGcodeDistance.Value = GCODE_DISTANCE.G90;
					if (scanf.Parse(line, "[gdi] default gcode distance mode %d [%s]") >= 1)
						cnc.DefaultGcodeDistance.Set(scanf, UseResponseItems.Checked);
					break;
				case "[baud":
					cnc.UsbBaudRate.Value = USB_BAUDRATE.Speed_115200;
					if (scanf.Parse(line, "[baud] USB baud rate %d [%s]") >= 1)
						cnc.UsbBaudRate.Set(scanf, UseResponseItems.Checked);
					break;
				default:
					LogAppend("Unknown:" + line, Color.OrangeRed);
					break;
			}
		}
		#endregion

		#region ParseMotorResponse 

		private void ParseMA(ref string line, string fmt, int idx)
		{
			cnc.Motors[idx].Axis.Value = MOTOR_AXIS.X;
			if (scanf.Parse(line, string.Concat(fmt, " map to axis %d")) == 1)
				cnc.Motors[idx].Axis.Set(scanf);
		}
		private void ParseSA(ref string line, string fmt, int idx)
		{
			cnc.Motors[idx].StepAngle = 1.8F;
			if (scanf.Parse(line, string.Concat(fmt, " step angle %f")) == 1)
				cnc.Motors[idx].StepAngle = (float)scanf.Results[0];
		}
		private void ParseTR(ref string line, string fmt, int idx)
		{
			cnc.Motors[idx].TravelPerRevolution.Value = 1.25F;
			if (scanf.Parse(line, string.Concat(fmt, " travel per revolution %f %s")) >= 1)
				cnc.Motors[idx].TravelPerRevolution.Set(scanf);
		}
		private void ParseMI(ref string line, string fmt, int idx)
		{
			cnc.Motors[idx].Microstep.Value = MOTOR_STEP.Step_8;
			if (scanf.Parse(line, string.Concat(fmt, " microsteps %d [%s]")) >= 1)
				cnc.Motors[idx].Microstep.Set(scanf, UseResponseItems.Checked);
		}
		private void ParsePO(ref string line, string fmt, int idx)
		{
			cnc.Motors[idx].Polarity.Value = MOTOR_POLARITY.Normal;
			if (scanf.Parse(line, string.Concat(fmt, " polarity %d [%s]")) >= 1)
				cnc.Motors[idx].Polarity.Set(scanf, UseResponseItems.Checked);
		}
		private void ParsePM(ref string line, string fmt, int idx)
		{
			cnc.Motors[idx].PowerManagement.Value = ON_OFF.Off;
			if (scanf.Parse(line, string.Concat(fmt, " power management %d [%s]")) >= 1)
				cnc.Motors[idx].PowerManagement.Set(scanf, UseResponseItems.Checked);
		}

		private void ParseMotorResponse(string line)
		{
			string key = line.Length >= 6 ? line.Substring(0, 6) : string.Empty;
			switch (key)
			{
				case "[1ma] ": ParseMA(ref line, "[1ma] m1", 0); break;
				case "[2ma] ": ParseMA(ref line, "[2ma] m2", 1); break;
				case "[3ma] ": ParseMA(ref line, "[3ma] m3", 2); break;
				case "[4ma] ": ParseMA(ref line, "[4ma] m4", 3); break;

				case "[1sa] ": ParseSA(ref line, "[1sa] m1", 0); break;
				case "[2sa] ": ParseSA(ref line, "[2sa] m2", 1); break;
				case "[3sa] ": ParseSA(ref line, "[3sa] m3", 2); break;
				case "[4sa] ": ParseSA(ref line, "[4sa] m4", 3); break;

				case "[1tr] ": ParseTR(ref line, "[1tr] m1", 0); break;
				case "[2tr] ": ParseTR(ref line, "[2tr] m2", 1); break;
				case "[3tr] ": ParseTR(ref line, "[3tr] m3", 2); break;
				case "[4tr] ": ParseTR(ref line, "[4tr] m4", 3); break;

				case "[1mi] ": ParseMI(ref line, "[1mi] m1", 0); break;
				case "[2mi] ": ParseMI(ref line, "[2mi] m2", 1); break;
				case "[3mi] ": ParseMI(ref line, "[3mi] m3", 2); break;
				case "[4mi] ": ParseMI(ref line, "[4mi] m4", 3); break;

				case "[1po] ": ParsePO(ref line, "[1po] m1", 0); break;
				case "[2po] ": ParsePO(ref line, "[2po] m2", 1); break;
				case "[3po] ": ParsePO(ref line, "[3po] m3", 2); break;
				case "[4po] ": ParsePO(ref line, "[4po] m4", 3); break;

				case "[1pm] ": ParsePM(ref line, "[1pm] m1", 0); break;
				case "[2pm] ": ParsePM(ref line, "[2pm] m2", 1); break;
				case "[3pm] ": ParsePM(ref line, "[3pm] m3", 2); break;
				case "[4pm] ": ParsePM(ref line, "[4pm] m4", 3); break;

				default:
					LogAppend("Unknown:" + line, Color.OrangeRed);
					break;
			}
		}
		#endregion

		#region ParseAxisResponse 

		private void ParseAM(ref string line, string fmt, int idx)
		{
			cnc.Axises[idx].AxisMode.Value = AXIS_MODE.Disabled;
			if (scanf.Parse(line, string.Concat(fmt, " axis mode %d")) == 1)
				cnc.Axises[idx].AxisMode.Set(scanf, UseResponseItems.Checked);
		}
		private void ParseVM(ref string line, string fmt, int idx)
		{
			cnc.Axises[idx].Velocity = 0F;
			if (scanf.Parse(line, string.Concat(fmt, " velocity maximum %f")) == 1)
				cnc.Axises[idx].Velocity = (float)scanf.Results[0];
		}
		private void ParseFR(ref string line, string fmt, int idx)
		{
			cnc.Axises[idx].Feedrate = 0F;
			if (scanf.Parse(line, string.Concat(fmt," feedrate maximum %f")) == 1)
				cnc.Axises[idx].Feedrate = (float)scanf.Results[0];
		}
		private void ParseJH(ref string line, string fmt, int idx)
		{
			cnc.Axises[idx].JerkHoming = 0;
			if (scanf.Parse(line, string.Concat(fmt, " jerk homing %d")) == 1)
				cnc.Axises[idx].JerkHoming = (int)scanf.Results[0];
		}
		private void ParseJD(ref string line, string fmt, int idx)
		{
			cnc.Axises[idx].JunctionDeviation = 0F;
			if (scanf.Parse(line, string.Concat(fmt, " junction deviation %f")) == 1)
				cnc.Axises[idx].JunctionDeviation = (float)scanf.Results[0];
		}
		private void ParseSN(ref string line, string fmt, int idx)
		{
			cnc.Axises[idx].SwitchMin.Value = AXIS_SWITCH.Off;
			if (scanf.Parse(line, string.Concat(fmt, " switch min %d [%s]")) == 2)
				cnc.Axises[idx].SwitchMin.Set(scanf, UseResponseItems.Checked);
		}
		private void ParseSX(ref string line, string fmt, int idx)
		{
			cnc.Axises[idx].SwitchMax.Value = AXIS_SWITCH.Off;
			if (scanf.Parse(line, string.Concat(fmt, " switch max %d [%s]")) == 2)
				cnc.Axises[idx].SwitchMax.Set(scanf, UseResponseItems.Checked);
		}
		private void ParseSV(ref string line, string fmt, int idx)
		{
			cnc.Axises[idx].SearchVelocity = 0F;
			if (scanf.Parse(line, string.Concat(fmt, " search velocity %f")) == 1)
				cnc.Axises[idx].SearchVelocity = (float)scanf.Results[0];
		}
		private void ParseLV(ref string line, string fmt, int idx)
		{
			cnc.Axises[idx].LatchVelocity = 0F;
			if (scanf.Parse(line, string.Concat(fmt, " latch velocity %f")) == 1)
				cnc.Axises[idx].LatchVelocity = (float)scanf.Results[0];
		}
		private void ParseLB(ref string line, string fmt, int idx)
		{
			cnc.Axises[idx].LatchBackoff = 0F;
			if (scanf.Parse(line, string.Concat(fmt, " latch backoff %f")) == 1)
				cnc.Axises[idx].LatchBackoff = (float)scanf.Results[0];
		}
		private void ParseZB(ref string line, string fmt, int idx)
		{
			cnc.Axises[idx].ZeroBackoff = 0F;
			if (scanf.Parse(line, string.Concat(fmt, " zero backoff %f")) == 1)
				cnc.Axises[idx].ZeroBackoff = (float)scanf.Results[0];
		}
		private void ParseTM(ref string line, string fmt, int idx)
		{
			cnc.Axises[idx].TravelMaximum = 0F;
			if (scanf.Parse(line, string.Concat(fmt, " travel maximum %f")) == 1)
				cnc.Axises[idx].TravelMaximum = (float)scanf.Results[0];
		}
		private void ParseJM(ref string line, string fmt, int idx)
		{
			cnc.Axises[idx].JerkMaximum = 0;
			if (scanf.Parse(line, string.Concat(fmt, " jerk maximum %d")) == 1)
				cnc.Axises[idx].JerkMaximum = (int)scanf.Results[0];
		}
		private void ParseRA(ref string line, string fmt, int idx)
		{
			cnc.Axises[idx].Radius = 0F;
			if (scanf.Parse(line, string.Concat(fmt, " radius value %f")) == 1)
				cnc.Axises[idx].Radius = (float)scanf.Results[0];
		}
		
		private void ParseAxisResponse(string line)
		{

			string key = line.Length >= 6 ? line.Substring(0, 6) : string.Empty;
			switch (key)
			{
				#region axis mode 
				case "[xam] ": ParseAM(ref line, "[xam] x", 0); break;
				case "[yam] ": ParseAM(ref line, "[yam] y", 1); break;
				case "[zam] ": ParseAM(ref line, "[zam] z", 2); break;
				case "[aam] ": ParseAM(ref line, "[aam] a", 3); break;
				case "[bam] ": ParseAM(ref line, "[bam] b", 4); break;
				case "[cam] ": ParseAM(ref line, "[cam] c", 5); break;
				#endregion

				#region velocity maximum 
				case "[xvm] ": ParseVM(ref line, "[xvm] x", 0); break;
				case "[yvm] ": ParseVM(ref line, "[yvm] y", 1); break;
				case "[zvm] ": ParseVM(ref line, "[zvm] z", 2); break;
				case "[avm] ": ParseVM(ref line, "[avm] a", 3); break;
				case "[bvm] ": ParseVM(ref line, "[bvm] b", 4); break;
				case "[cvm] ": ParseVM(ref line, "[cvm] c", 5); break;
				#endregion

				#region feedrate maximum
				case "[xfr] ": ParseFR(ref line, "[xfr] x", 0); break;
				case "[yfr] ": ParseFR(ref line, "[yfr] y", 1); break;
				case "[zfr] ": ParseFR(ref line, "[zfr] z", 2); break;
				case "[afr] ": ParseFR(ref line, "[afr] a", 3); break;
				case "[bfr] ": ParseFR(ref line, "[bfr] b", 4); break;
				case "[cfr] ": ParseFR(ref line, "[cfr] c", 5); break;
				#endregion

				#region jerk homing 
				case "[xjh] ": ParseJH(ref line, "[xjh] x", 0); break;
				case "[yjh] ": ParseJH(ref line, "[yjh] y", 1); break;
				case "[zjh] ": ParseJH(ref line, "[zjh] z", 2); break;
				case "[ajh] ": ParseJH(ref line, "[ajh] a", 3); break;
				case "[bjh] ": ParseJH(ref line, "[bjh] b", 4); break;
				case "[cjh] ": ParseJH(ref line, "[cjh] c", 5); break;
				#endregion

				#region junction deviation 
				case "[xjd] ": ParseJD(ref line, "[xjd] x", 0); break;
				case "[yjd] ": ParseJD(ref line, "[yjd] y", 1); break;
				case "[zjd] ": ParseJD(ref line, "[zjd] z", 2); break;
				case "[ajd] ": ParseJD(ref line, "[ajd] a", 3); break;
				case "[bjd] ": ParseJD(ref line, "[bjd] b", 4); break;
				case "[cjd] ": ParseJD(ref line, "[cjd] c", 5); break;
				#endregion

				#region switch min 
				case "[xsn] ": ParseSN(ref line, "[xsn] x", 0); break;
				case "[ysn] ": ParseSN(ref line, "[ysn] y", 1); break;
				case "[zsn] ": ParseSN(ref line, "[zsn] z", 2); break;
				case "[asn] ": ParseSN(ref line, "[asn] a", 3); break;
				case "[bsn] ": ParseSN(ref line, "[bsn] b", 4); break;
				case "[csn] ": ParseSN(ref line, "[csn] c", 5); break;
				#endregion

				#region switch max 
				case "[xsx] ": ParseSX(ref line, "[xsx] x", 0); break;
				case "[ysx] ": ParseSX(ref line, "[ysx] y", 1); break;
				case "[zsx] ": ParseSX(ref line, "[zsx] z", 2); break;
				case "[asx] ": ParseSX(ref line, "[asx] a", 3); break;
				case "[bsx] ": ParseSX(ref line, "[bsx] b", 4); break;
				case "[csx] ": ParseSX(ref line, "[csx] c", 5); break;
				#endregion

				#region search velocity 
				case "[xsv] ": ParseSV(ref line, "[xsv] x", 0); break;
				case "[ysv] ": ParseSV(ref line, "[ysv] y", 0); break;
				case "[zsv] ": ParseSV(ref line, "[zsv] z", 2); break;
				case "[asv] ": ParseSV(ref line, "[asv] a", 3); break;
				case "[bsv] ": ParseSV(ref line, "[bsv] b", 4); break;
				case "[csv] ": ParseSV(ref line, "[csv] c", 5); break;
				#endregion

				#region latch velocity 
				case "[xlv] ": ParseLV(ref line, "[xlv] x", 0); break;
				case "[ylv] ": ParseLV(ref line, "[ylv] y", 1); break;
				case "[zlv] ": ParseLV(ref line, "[zlv] z", 2); break;
				case "[alv] ": ParseLV(ref line, "[alv] a", 3); break;
				case "[blv] ": ParseLV(ref line, "[blv] b", 4); break;
				case "[clv] ": ParseLV(ref line, "[clv] c", 5); break;
				#endregion

				#region latch backoff 
				case "[xlb] ": ParseLB(ref line, "[xlb] x", 0); break;
				case "[ylb] ": ParseLB(ref line, "[ylb] y", 1); break;
				case "[zlb] ": ParseLB(ref line, "[zlb] z", 2); break;
				case "[alb] ": ParseLB(ref line, "[alb] a", 3); break;
				case "[blb] ": ParseLB(ref line, "[blb] b", 4); break;
				case "[clb] ": ParseLB(ref line, "[clb] c", 5); break;
				#endregion

				#region zero backoff 
				case "[xzb] ": ParseZB(ref line, "[xzb] x", 0); break;
				case "[yzb] ": ParseZB(ref line, "[yzb] y", 1); break;
				case "[zzb] ": ParseZB(ref line, "[zzb] z", 2); break;
				case "[azb] ": ParseZB(ref line, "[azb] a", 3); break;
				case "[bzb] ": ParseZB(ref line, "[bzb] b", 4); break;
				case "[czb] ": ParseZB(ref line, "[czb] c", 5); break;
				#endregion

				#region travel maximum 
				case "[xtm] ": ParseTM(ref line, "[xtm] x", 0); break;
				case "[ytm] ": ParseTM(ref line, "[ytm] y", 1); break;
				case "[ztm] ": ParseTM(ref line, "[ztm] z", 2); break;
				case "[atm] ": ParseTM(ref line, "[atm] a", 3); break;
				case "[btm] ": ParseTM(ref line, "[btm] b", 4); break;
				case "[ctm] ": ParseTM(ref line, "[ctm] c", 5); break;
				#endregion

				#region jerk maximum 
				case "[xjm] ": ParseJM(ref line, "[xjm] x", 0); break;
				case "[yjm] ": ParseJM(ref line, "[yjm] y", 1); break;
				case "[zjm] ": ParseJM(ref line, "[zjm] z", 2); break;
				case "[ajm] ": ParseJM(ref line, "[ajm] a", 3); break;
				case "[bjm] ": ParseJM(ref line, "[bjm] b", 4); break;
				case "[cjm] ": ParseJM(ref line, "[cjm] c", 5); break;
				#endregion

				#region radius value 
				case "[ara] ": ParseRA(ref line, "[ara] a", 3); break;
				case "[bra] ": ParseRA(ref line, "[bra] b", 4); break;
				case "[cra] ": ParseRA(ref line, "[cra] c", 5); break;
				#endregion

				default:
					LogAppend("Unknown:" + line, Color.OrangeRed);
					break;
			}
		}
		#endregion

		#region GetCncState 
		private void GetCncState()
		{
			List<string> responses = new List<string>();

			if (SendCommand("$sys", responses) == E_RESPONSE.E_OK)
				foreach (string line in responses)
					ParseSystemResponse(line);

			if (SendCommand("$m", responses) == E_RESPONSE.E_OK)
				foreach (string line in responses)
					ParseMotorResponse(line);

			if (SendCommand("$q", responses) == E_RESPONSE.E_OK)
				foreach (string line in responses)
					ParseAxisResponse(line);

			InfoFwBuild.Text = cnc.FirmwareBuild.ToString();
			InfoFwVersion.Text = cnc.FirmwareVersion.ToString();
			InfoHwVersion.Text = cnc.HardwareVersion.ToString();
			InfoID.Text = cnc.ID;

			JA.Set(cnc.JunctionAcceleration);
			CT.Set(cnc.ChordalTolerance);

			ST.Set(cnc.SwitchType);
			EJ.Set(cnc.JsonMode);
			JV.Set(cnc.JsonVerbosity);
			TV.Set(cnc.TextVerbosity);
			QV.Set(cnc.QueueReportVerbosity);
			SV.Set(cnc.StatusReportVerbosity);
			IC.Set(cnc.IgnoreCRLF);
			EC.Set(cnc.ExpandLF);
			EE.Set(cnc.EnableEcho);
			EX.Set(cnc.EnableXON);

			GPL.Set(cnc.DefaultGcodePlane);
			GUN.Set(cnc.DefaultGcodeUnits);
			GCO.Set(cnc.DefaultGcodeCoord);
			GPA.Set(cnc.DefaultGcodePath);
			GDI.Set(cnc.DefaultGcodeDistance);
			BAUD.Set(cnc.UsbBaudRate);

			SI.Text = cnc.StatusInterval.ToString();

			Motor1.Motor = cnc.Motors[0];
			Motor2.Motor = cnc.Motors[1];
			Motor3.Motor = cnc.Motors[2];
			Motor4.Motor = cnc.Motors[3];

			AxisX.Axis = cnc.Axises[0];
			AxisY.Axis = cnc.Axises[1];
			AxisZ.Axis = cnc.Axises[2];
			AxisA.Axis = cnc.Axises[3];

			m_setting_changed = false;
		}
		#endregion

		#region StartBtn_Click 
		private void StartBtn_Click(object sender, EventArgs e)
		{
			int baud = 0;
			if (PortSpeed.SelectedItem == null)
			{
				MessageBox.Show("Baudrate not select", "Error");
			}
			else if (!int.TryParse(PortSpeed.SelectedItem.ToString(), out baud))
			{
				MessageBox.Show("Invalid baudrate", "Error");
			}
			else if (PortsList.SelectedItem == null)
			{
				MessageBox.Show("Port not select", "Error");
			}
			else
			{
				serialPort.PortName = PortsList.SelectedItem.ToString();
				serialPort.DataBits = 8;
				serialPort.StopBits = StopBits.One;
				serialPort.Handshake = Handshake.None;
				serialPort.Parity = Parity.None;
				serialPort.BaudRate = baud;
				try
				{
					serialPort.Open();
					if (serialPort.IsOpen)
					{
						setPortOpenControls();

						if (SendCommand("\n") == E_RESPONSE.E_OK
						&& SendCommand("$ic=0\r\n") == E_RESPONSE.E_OK
						&& SendCommand("$ej=0") == E_RESPONSE.E_OK
						&& SendCommand("$ee=0") == E_RESPONSE.E_OK
						&& SendCommand("$ec=0") == E_RESPONSE.E_OK
						&& SendCommand("$ex=0") == E_RESPONSE.E_OK
							)
						{
							Set_mm_Btn_Click(sender, e);
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error");
					setPortCloseControls();
					if (serialPort.IsOpen)
						serialPort.Close();
				}
			}
		}
		#endregion

		#region StopBtn_Click 
		private bool ClosePort()
		{
			if (backgroundWorker.IsBusy)
			{
				if (MessageBox.Show("GCode send in progress. Cancel sending ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
					return false;
				backgroundWorker.CancelAsync();
				while (backgroundWorker.IsBusy)
				{
					Thread.Sleep(1000);
				}
			}
			return true;
		}

		private void StopBtn_Click(object sender, EventArgs e)
		{
			if (SettingUnchange())
			{
				if (ClosePort())
				{
					if (serialPort.IsOpen)
					{
						serialPort.Close();
						disableControlsForPrinting();
					}
					setPortCloseControls();
				}
			}
		}
		#endregion

		#region Set Port Open/Close Controls 
		private void setPortCloseControls()
		{
			PortsList.Enabled = true;
			ReloadBtn.Enabled = true;
			StartBtn.Enabled = true;
			StopBtn.Enabled = false;
			SettingsBtn.Enabled = false;
			CommandLine.ReadOnly = true;
			ControlTabs.Enabled = false;
			UseResponseItems.Enabled = false;
			RefreshBtn.Enabled = false;
			Set_mm_Btn.Enabled = false;
			Default_Btn.Enabled = false;
			Firmware_Btn.Enabled = false;

			disableControlsForPrinting();
		}

		private void setPortOpenControls()
		{
			PortsList.Enabled = false;
			ReloadBtn.Enabled = false;
			StartBtn.Enabled = false;
			StopBtn.Enabled = true;
			CommandLine.ReadOnly = false;
			ControlTabs.Enabled = true;
			UseResponseItems.Enabled = true;
			RefreshBtn.Enabled = true;
			Set_mm_Btn.Enabled = true;
			Default_Btn.Enabled = true;
			Firmware_Btn.Enabled = true;

			enableControlsForPrinting();
		}
		#endregion

		#region SendCommand 
		private E_RESPONSE SendCommand(string cmd)
		{
			return SendCommand(cmd, null);
		}

		private void StatusText(string text)
		{
			if (this.InvokeRequired)
			{
				this.BeginInvoke(new EventLogAppendHandler(StatusText), new object[] { text });
			}
			else
			{
				Status.Text = text;
			}
		}

		private E_RESPONSE SendCommand(string cmd, List<string> responses)
		{
			if (responses != null)
				responses.Clear();

			if (!serialPort.IsOpen)
				return E_RESPONSE.E_NOT_OPEN;

			m_auto_log = false;

			LogAppend(string.Concat("Cmd:", cmd), Color.LightSkyBlue);

			string cmdx = string.Concat(cmd, "\r");
			char[] buff = new char[cmdx.Length];
			buff = cmdx.ToCharArray();

			Responses.Clear();
			serialPort.Write(buff, 0, buff.Length);

			for (int timeout = 0; timeout < 1000; timeout++)
			{
				while (Responses.Count > 0)
				{
					string line = Responses.Dequeue();
					if (!string.IsNullOrEmpty(line))
					{
						if (line == CMD_RESPONSE_OK_mm || line == CMD_RESPONSE_OK_inch)
						{
							StatusText(string.Format("Command:{0} OK", cmd));
							LogGPlotDisplay();
							m_auto_log = true;
							return E_RESPONSE.E_OK;
						}
						if (line.StartsWith(CMD_RESPONSE_ERROR_mm, StringComparison.InvariantCultureIgnoreCase)
						|| line.StartsWith(CMD_RESPONSE_ERROR_inch, StringComparison.InvariantCultureIgnoreCase)
							)
						{
							StatusText(string.Format("Command:{0} ERROR", cmd));
							LogGPlotDisplay();
							m_auto_log = true;
							return E_RESPONSE.E_ERROR;
						}
						if (responses != null)
							responses.Add(line);
					}
				}
				Thread.Sleep(10);
			}
			StatusText(string.Format("Command:{0} TIMEOUT", cmd));
			LogGPlotDisplay();

			m_auto_log = true;
			return E_RESPONSE.E_TIMEOUT;
		}
		#endregion

		#region CommandLine_KeyPress 
		private void CommandLine_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				CommandLine.Text = CommandLine.Text.Trim();
				if (CommandLine.Text.Length > 0)
					SendCommand(CommandLine.Text);
			}
		}
		#endregion

		#region CNC_DataReceived 
		private void CNC_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			if (serialPort.BytesToRead > 0)
			{
				RxBuffer += serialPort.ReadExisting().Replace("\r", "");
				if (RxBuffer.Contains("\n"))
				{
					string[] lines = RxBuffer.Split(new char[] { '\n' });
					int iLines = lines.Length;
					if (RxBuffer.EndsWith("\n"))
					{
						RxBuffer = string.Empty;
					}
					else if (iLines >= 1)
					{
						RxBuffer = lines[iLines - 1];
						iLines--;
					}
					else
					{
						RxBuffer = string.Empty;
					}
					for (int i = 0; i < iLines; i++)
					{
						string line = lines[i];
						while (line.IndexOf("  ") >= 0)
							line = line.Replace("  ", " ");
						line = line.Trim();
						if (!string.IsNullOrEmpty(line))
						{
							if (line.StartsWith("[", StringComparison.InvariantCultureIgnoreCase)
							||	line.StartsWith("tinyg", StringComparison.InvariantCultureIgnoreCase))
							{
								while (Responses.Count >= 1000)
									for (int j = 0; j < 100; j++)
										Responses.Dequeue();
								Responses.Enqueue(line);
							}
							else if (line.StartsWith("{", StringComparison.InvariantCultureIgnoreCase))
							{
								// JSON response string
							}
							else
								GPlotAppend(line);
							LogAppend(line);
						}
					}
				}
			}
		}
		#endregion

		#region enableControlsForPrinting 
		private void enableControlsForPrinting()
		{
			Stop_Btn.Enabled = false;
			Send_Btn.Enabled = true;
			Load_Btn.Enabled = true;
			overrideSpeedChkbox.Enabled = true;
			speedOverrideNumber.Enabled = true;
			FileName.Enabled = true;

			mi_Run.Enabled = true;
			mi_Step.Enabled = true;
			mi_Stop.Enabled = false;
			mi_ToggleBP.Enabled = true;
			mi_DeleteAllBP.Enabled = true;

		}

		private void disableControlsForPrinting()
		{
			Send_Btn.Enabled = false;
			Load_Btn.Enabled = false;
			overrideSpeedChkbox.Enabled = false;
			speedOverrideNumber.Enabled = false;
			Stop_Btn.Enabled = true;
			FileName.Enabled = false;

			mi_Run.Enabled = false;
			mi_Step.Enabled = false;
			mi_Stop.Enabled = true;
			mi_ToggleBP.Enabled = false;
			mi_DeleteAllBP.Enabled = false;
		}
		#endregion

		#region loadPortSelector 
		private void loadPortSelector()
		{
			List<String> sortedPortsList = new List<String>();

			PortsList.Items.Clear();

			foreach (string portname in SerialPort.GetPortNames())
				sortedPortsList.Add(portname);

			if (sortedPortsList.Count < 1)
				MessageBox.Show("No serial ports found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
			{
				sortedPortsList.Sort();
				PortsList.Items.AddRange(sortedPortsList.ToArray());
				PortsList.SelectedIndex = 0;
			}
		}
		#endregion

		#region ReloadBtn_Click 
		private void ReloadBtn_Click(object sender, EventArgs e)
		{
			loadPortSelector();
		}
		#endregion

		#region SettingsBtn_Click 
		private void SettingsBtn_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Not implemented");
		}
		#endregion

		#region Manual move
		private void MoveHome_Click(object sender, EventArgs e)
		{
			SendCommand("M5");
			SendCommand("G0 X0 Y0");
		}

		private void MoveYP_Click(object sender, EventArgs e)
		{
			SendCommand("G91 G0 Y-" + MoveStep.Value.ToString(Culture));
		}
		private void MoveYM_Click(object sender, EventArgs e)
		{
			SendCommand("G91 G0 Y+" + MoveStep.Value.ToString(Culture));
		}
		private void MoveXP_Click(object sender, EventArgs e)
		{
			SendCommand("G91 G0 X+" + MoveStep.Value.ToString(Culture));
		}
		private void MoveXM_Click(object sender, EventArgs e)
		{
			SendCommand("G91 G0 X-" + MoveStep.Value.ToString(Culture));
		}

		private void MoveYPXP_Click(object sender, EventArgs e)
		{
			SendCommand("G91 G0 X+" + MoveStep.Value.ToString(Culture) + " Y-" + MoveStep.Value.ToString(Culture));
		}

		private void MoveYPXM_Click(object sender, EventArgs e)
		{
			SendCommand("G91 G0 X-" + MoveStep.Value.ToString(Culture) + " Y-" + MoveStep.Value.ToString(Culture));
		}

		private void MoveYMXP_Click(object sender, EventArgs e)
		{
			SendCommand("G91 G0 X+" + MoveStep.Value.ToString(Culture) + " Y+" + MoveStep.Value.ToString(Culture));
		}

		private void MoveYMXM_Click(object sender, EventArgs e)
		{
			SendCommand("G91 G0 X-" + MoveStep.Value.ToString(Culture) + " Y+" + MoveStep.Value.ToString(Culture));
		}

		private void MoveZP_Click(object sender, EventArgs e)
		{
			SendCommand("G91 G0 Z+" + MoveStep.Value.ToString(Culture));
		}

		private void MoveZM_Click(object sender, EventArgs e)
		{
			SendCommand("G91 G0 Z-" + MoveStep.Value.ToString(Culture));
		}
		#endregion

		#region UseResponseItems_CheckedChanged 
		private void UseResponseItems_CheckedChanged(object sender, EventArgs e)
		{
			GetCncState();
		}
		#endregion

		#region Setting_Changed 
		private void Setting_Changed(object sender, EventArgs e)
		{
			m_setting_changed = true;
			SettingsBtn.Enabled = true;
		}
		#endregion

		#region ClearBtn_Click 
		private void ClearBtn_Click(object sender, EventArgs e)
		{
			if (TabLogGraph.SelectedIndex == 0)
				Log.Items.Clear();
			else if (TabLogGraph.SelectedIndex == 1)
			{
				GPlotGraphics.Clear(GPlotPicture.BackColor);
				GPlotPicture.Refresh();
			}
		}
		#endregion

		#region GPlot Append / Display
		private class GPoint
		{
			public float? Velocity;
			public float? X;
			public float? Y;
			public float? Z;
			public float? A;
			public float? B;
			public float? C;
			public bool Invalid;
			public int Status;
			public int Momo;

			public bool IsEmpty
			{
				get { return !(X.HasValue || Y.HasValue || Z.HasValue || A.HasValue || B.HasValue || C.HasValue); }
			}

			public GPoint()
			{
				Invalid = false;
			}

			public GPoint(float x, float y, float z)
			{
				X = x;
				Y = y;
				Z = z;
				Invalid = false;
			}

			public GPoint(GPoint gp)
			{
				X = gp.X;
				Y = gp.Y;
				Z = gp.Z;
				A = gp.A;
				B = gp.B;
				C = gp.C;
				Invalid = false;
			}
		}

		private void GPlotAppend(string line)
		{
			if (!string.IsNullOrEmpty(line))
			{
				GPoint point = new GPoint();
				float f_value;
				int i_value;
				string[] tokens = line.Split(Common.CHAR_COMMA, StringSplitOptions.RemoveEmptyEntries);

				foreach (string token in tokens)
				{
					int idx = token.IndexOf(':');
					if (idx <= 0)
						continue;
					string key = token.Substring(0, idx).ToLowerInvariant();
					string value = (idx+1 < token.Length) ? token.Substring(idx+1).Trim() : string.Empty;
					if (value.Length > 0)
					{
						idx = value.IndexOf(' ');
						if (idx > 0)
							value = value.Substring(0, idx);
					}
					switch (key)
					{
						case "posx":
							if (float.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out f_value))
								point.X = f_value;
							else
								point.Invalid = true;
							break;
						case "posy":
							if (float.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out f_value))
								point.Y = f_value;
							else
								point.Invalid = true;
							break;
						case "posz":
							if (float.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out f_value))
								point.Z = f_value;
							else
								point.Invalid = true;
							break;
						case "vel":
							if (float.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out f_value))
								point.Velocity = f_value;
							break;
						case "stat":
							// 5	Start
							// 3	Stop
							if (int.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out i_value))
								point.Status = i_value;
							switch (i_value)
							{
								case 5:
									break;
								case 3:
									break;
								default:
									break;
							}
							break;
						case "momo":
							if (int.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out i_value))
								point.Momo = i_value;
							switch (i_value)
							{
								case 0:
									break;
								case 1:
									break;
								case 2:
									break;
								case 3:
									break;
								default:
									break;
							}
							break;
						case "frmo":
						case "dist":
						case "unit":
							break;
						case "coor":
							break;
						case "posa":
							break;
						case "feed":
							break;
						case "line":
							break;
						case "line number":
							break;
						case "x position":
							if (float.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out f_value))
								GPlotCurrent.X = f_value;
							break;
						case "y position":
							if (float.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out f_value))
								GPlotCurrent.Y = f_value;
							break;
						case "z position":
							if (float.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out f_value))
								GPlotCurrent.Z = f_value;
							break;
						case "a position":
							break;
						case "feed rate":
							break;
						case "velocity":
							break;
						case "units":
							break;
						case "coordinate system":
							break;
						case "distance mode":
							break;
						case "feed rate mode":
							break;
						case "motion mode":
							break;
						case "machine state":
							break;
						default:
							break;
					}
				}

				if (!point.Invalid &&
					!point.IsEmpty &&
					GPlotQueue.Count < GPLOT_QUEUE_SIZE
					)
					GPlotQueue.Enqueue(point);
			}
		}
		#endregion

		#region Log Append/Display

		private delegate void EventLogDisplayHandler();
		private delegate void EventLogAppendColorHandler(string line, Color color);
		private delegate void EventLogAppendHandler(string line);

		private void LogAppend(string line, Color color)
		{
			if (LogQueue.Count < LOG_QUEUE_SIZE)
			{
				ListViewItem lvi = new ListViewItem(line);
				lvi.BackColor = color;
				LogQueue.Enqueue(lvi);
			}
		}

		private void LogAppend(string line)
		{
			if (LogQueue.Count < LOG_QUEUE_SIZE)
			{
				ListViewItem lvi = new ListViewItem(line);
				if (line == CMD_RESPONSE_OK_mm
				|| line == CMD_RESPONSE_OK_inch)
					lvi.BackColor = Color.LightGreen;
				else if (line.StartsWith(CMD_RESPONSE_ERROR_mm, StringComparison.InvariantCultureIgnoreCase)
					|| line.StartsWith(CMD_RESPONSE_ERROR_inch, StringComparison.InvariantCultureIgnoreCase)
					)
					lvi.BackColor = Color.LightPink;
				LogQueue.Enqueue(lvi);
			}
			if (m_auto_log)
			{
				LogGPlotDisplay();
				timer.Start();
			}
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			timer.Stop();
			LogGPlotDisplay();
		}

		private void LogGPlotDisplay()
		{
			if (this.InvokeRequired)
			{
				if (!m_log_invoke)
				{
					m_log_invoke = true;
					this.BeginInvoke(new EventLogDisplayHandler(LogGPlotDisplay));
				}
				return;
			}

			if (LogQueue.Count == 0 && GPlotQueue.Count == 0)
			{
				m_log_invoke = false;
				return;
			}

			this.SuspendLayout();
			while (LogQueue.Count > 0)
			{
				ListViewItem lvi = LogQueue.Dequeue();
				Log.Items.Add(lvi);
			}
			if (Log.Items.Count > 0)
				Log.EnsureVisible(Log.Items.Count - 1);

			if (GPlotQueue.Count > 0)
			{
				while (GPlotQueue.Count > 0)
				{
					GPoint next = new GPoint(GPlotCurrent);
					GPoint point = GPlotQueue.Dequeue();

					if (point.X.HasValue) next.X = point.X.Value;
					if (point.Y.HasValue) next.Y = point.Y.Value;
					if (point.Z.HasValue) next.Z = point.Z.Value;
					if (point.A.HasValue) next.A = point.A.Value;
					if (point.B.HasValue) next.A = point.B.Value;
					if (point.C.HasValue) next.C = point.C.Value;

					GPlotGraphics.DrawLine(
						(next.Z >= (float)ZLevel.Value)
						? GPlotPenP
						: GPlotPenM,
						new Point(NormalizeX(GPlotCurrent.X.Value), NormalizeY(GPlotCurrent.Y.Value)),
						new Point(NormalizeX(next.X.Value), NormalizeY(next.Y.Value))
						);
					GPlotCurrent = next;
				}
				GPlotPicture.Refresh();
			}
			CurrentX.Text = CurrentX2.Text = GPlotCurrent.X.HasValue ? GPlotCurrent.X.Value.ToString(Culture) : "-";
			CurrentY.Text = CurrentY2.Text = GPlotCurrent.Y.HasValue ? GPlotCurrent.Y.Value.ToString(Culture) : "-";
			CurrentZ.Text = CurrentZ2.Text = GPlotCurrent.Z.HasValue ? GPlotCurrent.Z.Value.ToString(Culture) : "-";
			CurrentA.Text = CurrentA2.Text = GPlotCurrent.A.HasValue ? GPlotCurrent.A.Value.ToString(Culture) : "-";

			this.ResumeLayout(false);
			m_log_invoke = false;
		}

		private int NormalizeX(float value)
		{
			float range2 = (float)(GPlotBitmap.Width / 2);
			value *= GPlotScale.Width;
			value = Math.Max(value, -range2);
			value = Math.Min(value, range2);
			return Convert.ToInt32(value + range2);
		}

		private int NormalizeY(float value)
		{
			float range2 = (float)(GPlotBitmap.Height / 2);
			value *= GPlotScale.Height;
			value = Math.Max(value, -range2);
			value = Math.Min(value, range2);
			return Convert.ToInt32(value + range2);
		}
		#endregion

		#region Stop_Btn_Click / Start_Btn_Click 

		private void Stop_Btn_Click(object sender, EventArgs e)
		{
			backgroundWorker.CancelAsync();
		}

		private void StartGCode(bool step)
		{
			try
			{
				if (!serialPort.IsOpen)
				{
					enableControlsForPrinting();
					MessageBox.Show("Port not open.");
				}
				else if (GCodes.Items.Count == 0)
				{
					enableControlsForPrinting();
					MessageBox.Show("GCode list empty.");
				}
				else
				{
					disableControlsForPrinting();
					SentRowsLbl.Text = "Sent rows: 0";

					List<GCodeListViewItem> gcodes = new List<GCodeListViewItem>(GCodes.Items.Count);
					foreach (GCodeListViewItem gcode in GCodes.Items)
						gcodes.Add(gcode);
					backgroundWorker.RunWorkerAsync(new object[] { step, gcodes });
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void Send_Btn_Click(object sender, EventArgs e)
		{
			StartGCode(false);
		}

		private bool worker_progress = true;

		private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			List<string> responses = new List<string>();

			object[] param = (object[])e.Argument;
			bool step_mode = (bool)param[0];
			List<GCodeListViewItem> gcodes = (List<GCodeListViewItem>)param[1];

			BackgroundWorker worker = (BackgroundWorker)sender;
			e.Result = E_RESPONSE.E_OK;

			worker_progress = true;
			bool check_bp = false;

			while (GCodes.CurrentLine < gcodes.Count)
			{
				if (worker.CancellationPending)
				{
					e.Cancel = true;
					break;
				}
				if (GCodes.CurrentLine == GCodes.StopLine)
					break;

				GCodeListViewItem gcodeItem = gcodes[GCodes.CurrentLine];
				string gcode = gcodeItem.SubItems[1].Text;
				if (check_bp && gcodeItem.Breakpoint)
					break;
				check_bp = true;

				int idx;
				// Check if we need to override and F command. This is a little rude, we just replaces first F in line...
				if (overrideSpeedChkbox.Checked && (idx = gcode.ToLower().IndexOf("f", StringComparison.InvariantCultureIgnoreCase)) >= 0)
				{
					// Yea, this can be done a lot better.
					idx++;
					if (idx < gcode.Length)
					{
						string firstPart = gcode.Substring(0, idx);
						string lastPart = gcode.Substring(idx);
						lastPart = Regex.Replace(lastPart, "^\\d+(.\\d*)", speedOverrideNumber.Value.ToString());
						gcode = firstPart + lastPart;
					}
				}

				if (SendCommand(gcode, responses) != E_RESPONSE.E_OK)
				{
					if (!IgnoreGCodeErrors.Checked)
					{
						e.Result = E_RESPONSE.E_ERROR;
						break;
					}
				}

				GCodes.CurrentLine++;

				if (step_mode)
				{
					break;
				}
				else if (worker_progress)
				{
					worker_progress = false;
					worker.ReportProgress(0, false);
				}
			}
			GCodes.StopLine = -1;
			worker.ReportProgress(0, true);
		}

		private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			// WorkerState state = (WorkerState)e.UserState;
			bool complete = (bool)e.UserState;

			if (complete)
			{
				SentRowsLbl.Text = "Sent rows: " + GCodes.CurrentLine.ToString();
			}
			else
			{
				if (GCodes.CurrentLine % 10 == 0)
					SentRowsLbl.Text = "Sent rows: " + GCodes.CurrentLine.ToString();
			}

			SetGCodeRowCurrent();
			worker_progress = true;
		}

		private void SetGCodeRowCurrent()
		{
			int current = GCodes.CurrentLine;
			if (current != GCodes.SavedLine)
			{
				SetGCodeRowAttributes(GCodes.SavedLine);
				SetGCodeRowAttributes(current);
				if (current < GCodes.Items.Count)
				{
					GCodes.Items[current].Selected = true;
					GCodes.EnsureVisible(current);
					GCodes.SavedLine = current;
				}
			}
		}

		private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Error != null)
				MessageBox.Show("Error: " + e.Error.Message);
			else if (e.Cancelled)
				StatusText("GCode send canceled.");
			else if(e.Result.Equals(E_RESPONSE.E_OK))
				StatusText("All the G-code was sent.");
			else
				MessageBox.Show("Error during send commands.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			enableControlsForPrinting();
			// LogGPlotDisplay();
		}
		#endregion

		#region Set_mm_Btn_Click 
		private void Set_mm_Btn_Click(object sender, EventArgs e)
		{
			if (SendCommand("$gun=1") == E_RESPONSE.E_OK
			&& SendCommand("↑") == E_RESPONSE.E_OK
			// && SendCommand("\x18") == E_RESPONSE.E_OK
				)
				GetCncState();
		}
		#endregion

		#region Default_Btn_Click 
		private void Default_Btn_Click(object sender, EventArgs e)
		{
			if (SendCommand("$defa=1") == E_RESPONSE.E_OK)
				GetCncState();
		}
		#endregion

		#region Firmware_Btn_Click 
		private void Firmware_Btn_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Not implemented", "Error");
			/*
			openFileDialog.Filter = "Firmware Files|*.hex;*.bin|All files|*.*";
			openFileDialog.FileName = "";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				// Software reset
			}
			*/
		}
		#endregion

		/*
		private void GCodes_KeyDown(object sender, KeyEventArgs e)
		{
			bool handled = false;

			if (e.Shift && e.Control && !e.Alt)
			{
				if (e.KeyCode == Keys.F10)
				{
					GCodeSetCurrent();
					handled = true;
				}
			}

			if (!e.Shift && e.Control && !e.Alt)
			{
				if (e.KeyCode == Keys.F10)
				{
					GCodeRunStep();
					handled = true;
				}
			}

			if (!e.Shift && !e.Control && !e.Alt)
			{
				if (e.KeyCode == Keys.F9)
				{
					GCodeToggleBreakPoint();
					handled = true;
				}
				if (e.KeyCode == Keys.F10)
				{
					GCodeRun();
					handled = true;
				}
			}
			if (handled)
			{
				e.Handled = true;
				e.SuppressKeyPress = true;
			}
		}
		private void GCodeMenu_Click(object sender, EventArgs e)
		{

		}
		*/

		private void mi_Run_Click(object sender, EventArgs e)
		{
			Send_Btn_Click(sender, e);
		}

		private void mi_Step_Click(object sender, EventArgs e)
		{
			StartGCode(true);
		}

		private void TabLogGraph_SelectedIndexChanged(object sender, EventArgs e)
		{
			Debug_Btn.Visible = (TabLogGraph.SelectedIndex == 2);
		}

		private void Debug_Btn_Click(object sender, EventArgs e)
		{
			GCodeMenu.Show(Debug_Btn, new Point(0, Debug_Btn.Height));
		}

		private void SetGCodeRowAttributes(int index)
		{
			if (index < GCodes.Items.Count)
			{
				GCodeListViewItem gcode = GCodes.Items[index] as GCodeListViewItem;
				if (gcode != null)
					SetGCodeRowAttributes(gcode);
			}
		}

		private void SetGCodeRowAttributes(GCodeListViewItem gcode)
		{
			SetGCodeRowBP(gcode);
			if (gcode.Index == GCodes.CurrentLine)
				gcode.BackColor = GCODE_CURRENT;
		}

		private void SetGCodeRowBP(GCodeListViewItem gcode)
		{
			if (gcode.Breakpoint)
			{
				gcode.ImageIndex = 1;
				gcode.BackColor = GCODE_BREAKPOINT;
			}
			else
			{
				gcode.ImageIndex = -1;
				gcode.BackColor = Color.FromKnownColor(KnownColor.Window);
			}
		}

		private void mi_ToggleBP_Click(object sender, EventArgs e)
		{
			if (GCodes.SelectedItems != null && GCodes.SelectedItems.Count >= 1)
			{
				GCodeListViewItem gcode = GCodes.SelectedItems[0] as GCodeListViewItem;
				if (gcode != null)
				{
					gcode.Breakpoint = !gcode.Breakpoint;
					SetGCodeRowAttributes(gcode);
				}
			}
		}

		private void mi_DeleteAllBP_Click(object sender, EventArgs e)
		{
			foreach (GCodeListViewItem gcode in GCodes.Items)
				if (gcode != null && gcode.Breakpoint)
				{
					gcode.Breakpoint = false;
					SetGCodeRowAttributes(gcode);
				}
		}

		private void mi_Stop_Click(object sender, EventArgs e)
		{
			Stop_Btn_Click(sender, e);
		}

		private void mi_NextCommand_Click(object sender, EventArgs e)
		{
			if (GCodes.SelectedItems != null)
			{
				GCodes.CurrentLine = GCodes.SelectedItems[0].Index;
				SetGCodeRowCurrent();
			}
		}

		private void mi_RunToCursor_Click(object sender, EventArgs e)
		{
			if (GCodes.SelectedItems != null)
			{
				GCodes.StopLine = GCodes.SelectedItems[0].Index;
				StartGCode(false);
			}
		}
	}
}
