namespace CNCGUI
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.serialPort = new System.IO.Ports.SerialPort(this.components);
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.Load_Btn = new System.Windows.Forms.Button();
			this.StartBtn = new System.Windows.Forms.Button();
			this.FileName = new System.Windows.Forms.TextBox();
			this.StopBtn = new System.Windows.Forms.Button();
			this.CommandLine = new System.Windows.Forms.TextBox();
			this.Send_Btn = new System.Windows.Forms.Button();
			this.PortsList = new System.Windows.Forms.ComboBox();
			this.RowsInFileLbl = new System.Windows.Forms.Label();
			this.SentRowsLbl = new System.Windows.Forms.Label();
			this.Stop_Btn = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.PortSpeed = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.ReloadBtn = new System.Windows.Forms.Button();
			this.speedOverrideNumber = new System.Windows.Forms.NumericUpDown();
			this.overrideSpeedChkbox = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SettingsBtn = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.Status = new System.Windows.Forms.ToolStripStatusLabel();
			this.ControlTabs = new System.Windows.Forms.TabControl();
			this.PageSettings = new System.Windows.Forms.TabPage();
			this.label26 = new System.Windows.Forms.Label();
			this.BAUD = new CNCGUI.ComboBoxEnum();
			this.label25 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.GDI = new CNCGUI.ComboBoxEnum();
			this.label23 = new System.Windows.Forms.Label();
			this.GPA = new CNCGUI.ComboBoxEnum();
			this.label22 = new System.Windows.Forms.Label();
			this.GCO = new CNCGUI.ComboBoxEnum();
			this.label21 = new System.Windows.Forms.Label();
			this.GUN = new CNCGUI.ComboBoxEnum();
			this.label20 = new System.Windows.Forms.Label();
			this.GPL = new CNCGUI.ComboBoxEnum();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.EE = new CNCGUI.ComboBoxEnum();
			this.EC = new CNCGUI.ComboBoxEnum();
			this.label17 = new System.Windows.Forms.Label();
			this.IC = new CNCGUI.ComboBoxEnum();
			this.label16 = new System.Windows.Forms.Label();
			this.SI = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.EX = new CNCGUI.ComboBoxEnum();
			this.label14 = new System.Windows.Forms.Label();
			this.SV = new CNCGUI.ComboBoxEnum();
			this.label13 = new System.Windows.Forms.Label();
			this.QV = new CNCGUI.ComboBoxEnum();
			this.label12 = new System.Windows.Forms.Label();
			this.TV = new CNCGUI.ComboBoxEnum();
			this.label11 = new System.Windows.Forms.Label();
			this.JV = new CNCGUI.ComboBoxEnum();
			this.label10 = new System.Windows.Forms.Label();
			this.EJ = new CNCGUI.ComboBoxEnum();
			this.label9 = new System.Windows.Forms.Label();
			this.ST = new CNCGUI.ComboBoxEnum();
			this.CT = new CNCGUI.ValueUnitControl();
			this.JA = new CNCGUI.ValueUnitControl();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.InfoID = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.InfoHwVersion = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.InfoFwVersion = new System.Windows.Forms.TextBox();
			this.InfoFwBuild = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.PageMotors = new System.Windows.Forms.TabPage();
			this.Motor4 = new CNCGUI.MotorControl();
			this.Motor3 = new CNCGUI.MotorControl();
			this.Motor2 = new CNCGUI.MotorControl();
			this.Motor1 = new CNCGUI.MotorControl();
			this.PageAxises = new System.Windows.Forms.TabPage();
			this.AxisA = new CNCGUI.AxisControl();
			this.AxisZ = new CNCGUI.AxisControl();
			this.AxisY = new CNCGUI.AxisControl();
			this.AxisX = new CNCGUI.AxisControl();
			this.Page1 = new System.Windows.Forms.TabPage();
			this.label31 = new System.Windows.Forms.Label();
			this.CurrentA = new System.Windows.Forms.TextBox();
			this.label30 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.CurrentZ = new System.Windows.Forms.TextBox();
			this.CurrentY = new System.Windows.Forms.TextBox();
			this.CurrentX = new System.Windows.Forms.TextBox();
			this.MoveStep = new System.Windows.Forms.NumericUpDown();
			this.MoveYMXM = new System.Windows.Forms.Button();
			this.MoveYPXM = new System.Windows.Forms.Button();
			this.MoveYMXP = new System.Windows.Forms.Button();
			this.MoveYPXP = new System.Windows.Forms.Button();
			this.MoveZM = new System.Windows.Forms.Button();
			this.MoveZP = new System.Windows.Forms.Button();
			this.MoveHome = new System.Windows.Forms.Button();
			this.MoveYM = new System.Windows.Forms.Button();
			this.MoveYP = new System.Windows.Forms.Button();
			this.MoveXM = new System.Windows.Forms.Button();
			this.MoveXP = new System.Windows.Forms.Button();
			this.Page2 = new System.Windows.Forms.TabPage();
			this.label32 = new System.Windows.Forms.Label();
			this.CurrentA2 = new System.Windows.Forms.TextBox();
			this.label33 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.CurrentZ2 = new System.Windows.Forms.TextBox();
			this.CurrentY2 = new System.Windows.Forms.TextBox();
			this.CurrentX2 = new System.Windows.Forms.TextBox();
			this.IgnoreGCodeErrors = new System.Windows.Forms.CheckBox();
			this.UseResponseItems = new System.Windows.Forms.CheckBox();
			this.RefreshBtn = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.ClearBtn = new System.Windows.Forms.Button();
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.TabLogGraph = new System.Windows.Forms.TabControl();
			this.PageLog = new System.Windows.Forms.TabPage();
			this.Log = new CNCGUI.GCodeListView();
			this.LogColumn1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PageGraph = new System.Windows.Forms.TabPage();
			this.label27 = new System.Windows.Forms.Label();
			this.ZLevel = new System.Windows.Forms.NumericUpDown();
			this.GPlotPicture = new System.Windows.Forms.PictureBox();
			this.PageGCode = new System.Windows.Forms.TabPage();
			this.GCodes = new CNCGUI.GCodeListView();
			this.columnBP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnGCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.GCodeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mi_Run = new System.Windows.Forms.ToolStripMenuItem();
			this.mi_Step = new System.Windows.Forms.ToolStripMenuItem();
			this.mi_Stop = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.mi_ToggleBP = new System.Windows.Forms.ToolStripMenuItem();
			this.mi_DeleteAllBP = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.mi_NextCommand = new System.Windows.Forms.ToolStripMenuItem();
			this.GCodeImages = new System.Windows.Forms.ImageList(this.components);
			this.Set_mm_Btn = new System.Windows.Forms.Button();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.Default_Btn = new System.Windows.Forms.Button();
			this.Firmware_Btn = new System.Windows.Forms.Button();
			this.Debug_Btn = new System.Windows.Forms.Button();
			this.mi_RunToCursor = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.speedOverrideNumber)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.ControlTabs.SuspendLayout();
			this.PageSettings.SuspendLayout();
			this.PageMotors.SuspendLayout();
			this.PageAxises.SuspendLayout();
			this.Page1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MoveStep)).BeginInit();
			this.Page2.SuspendLayout();
			this.TabLogGraph.SuspendLayout();
			this.PageLog.SuspendLayout();
			this.PageGraph.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ZLevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GPlotPicture)).BeginInit();
			this.PageGCode.SuspendLayout();
			this.GCodeMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// serialPort
			// 
			this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.CNC_DataReceived);
			// 
			// Load_Btn
			// 
			this.Load_Btn.Location = new System.Drawing.Point(307, 24);
			this.Load_Btn.Margin = new System.Windows.Forms.Padding(4);
			this.Load_Btn.Name = "Load_Btn";
			this.Load_Btn.Size = new System.Drawing.Size(100, 30);
			this.Load_Btn.TabIndex = 0;
			this.Load_Btn.Text = "Load ...";
			this.Load_Btn.UseVisualStyleBackColor = true;
			this.Load_Btn.Click += new System.EventHandler(this.Load_Btn_Click);
			// 
			// StartBtn
			// 
			this.StartBtn.Location = new System.Drawing.Point(94, 45);
			this.StartBtn.Margin = new System.Windows.Forms.Padding(4);
			this.StartBtn.Name = "StartBtn";
			this.StartBtn.Size = new System.Drawing.Size(100, 30);
			this.StartBtn.TabIndex = 2;
			this.StartBtn.Text = "Open";
			this.StartBtn.UseVisualStyleBackColor = true;
			this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
			// 
			// FileName
			// 
			this.FileName.Location = new System.Drawing.Point(7, 27);
			this.FileName.Margin = new System.Windows.Forms.Padding(4);
			this.FileName.Name = "FileName";
			this.FileName.Size = new System.Drawing.Size(291, 22);
			this.FileName.TabIndex = 2;
			this.FileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// StopBtn
			// 
			this.StopBtn.Enabled = false;
			this.StopBtn.Location = new System.Drawing.Point(94, 78);
			this.StopBtn.Margin = new System.Windows.Forms.Padding(4);
			this.StopBtn.Name = "StopBtn";
			this.StopBtn.Size = new System.Drawing.Size(100, 30);
			this.StopBtn.TabIndex = 4;
			this.StopBtn.Text = "Close";
			this.StopBtn.UseVisualStyleBackColor = true;
			this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
			// 
			// CommandLine
			// 
			this.CommandLine.Location = new System.Drawing.Point(87, 19);
			this.CommandLine.Margin = new System.Windows.Forms.Padding(4);
			this.CommandLine.Name = "CommandLine";
			this.CommandLine.ReadOnly = true;
			this.CommandLine.Size = new System.Drawing.Size(257, 22);
			this.CommandLine.TabIndex = 3;
			this.CommandLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CommandLine_KeyPress);
			// 
			// Send_Btn
			// 
			this.Send_Btn.Location = new System.Drawing.Point(7, 58);
			this.Send_Btn.Margin = new System.Windows.Forms.Padding(4);
			this.Send_Btn.Name = "Send_Btn";
			this.Send_Btn.Size = new System.Drawing.Size(69, 30);
			this.Send_Btn.TabIndex = 8;
			this.Send_Btn.Text = "Send";
			this.Send_Btn.UseVisualStyleBackColor = true;
			this.Send_Btn.Click += new System.EventHandler(this.Send_Btn_Click);
			// 
			// PortsList
			// 
			this.PortsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PortsList.FormattingEnabled = true;
			this.PortsList.Location = new System.Drawing.Point(5, 49);
			this.PortsList.Margin = new System.Windows.Forms.Padding(4);
			this.PortsList.Name = "PortsList";
			this.PortsList.Size = new System.Drawing.Size(81, 24);
			this.PortsList.TabIndex = 0;
			// 
			// RowsInFileLbl
			// 
			this.RowsInFileLbl.AutoSize = true;
			this.RowsInFileLbl.Location = new System.Drawing.Point(148, 99);
			this.RowsInFileLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.RowsInFileLbl.Name = "RowsInFileLbl";
			this.RowsInFileLbl.Size = new System.Drawing.Size(58, 17);
			this.RowsInFileLbl.TabIndex = 12;
			this.RowsInFileLbl.Text = "Rows: 0";
			// 
			// SentRowsLbl
			// 
			this.SentRowsLbl.AutoSize = true;
			this.SentRowsLbl.Location = new System.Drawing.Point(7, 99);
			this.SentRowsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.SentRowsLbl.Name = "SentRowsLbl";
			this.SentRowsLbl.Size = new System.Drawing.Size(86, 17);
			this.SentRowsLbl.TabIndex = 13;
			this.SentRowsLbl.Text = "Sent rows: 0";
			// 
			// Stop_Btn
			// 
			this.Stop_Btn.Enabled = false;
			this.Stop_Btn.Location = new System.Drawing.Point(84, 58);
			this.Stop_Btn.Margin = new System.Windows.Forms.Padding(4);
			this.Stop_Btn.Name = "Stop_Btn";
			this.Stop_Btn.Size = new System.Drawing.Size(69, 30);
			this.Stop_Btn.TabIndex = 14;
			this.Stop_Btn.Text = "Stop";
			this.Stop_Btn.UseVisualStyleBackColor = true;
			this.Stop_Btn.Click += new System.EventHandler(this.Stop_Btn_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.PortSpeed);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.CommandLine);
			this.groupBox1.Controls.Add(this.StartBtn);
			this.groupBox1.Controls.Add(this.StopBtn);
			this.groupBox1.Controls.Add(this.PortsList);
			this.groupBox1.Controls.Add(this.ReloadBtn);
			this.groupBox1.Location = new System.Drawing.Point(8, 6);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(353, 112);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Serial";
			// 
			// PortSpeed
			// 
			this.PortSpeed.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.PortSpeed.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.PortSpeed.FormattingEnabled = true;
			this.PortSpeed.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400"});
			this.PortSpeed.Location = new System.Drawing.Point(5, 82);
			this.PortSpeed.Name = "PortSpeed";
			this.PortSpeed.Size = new System.Drawing.Size(81, 24);
			this.PortSpeed.TabIndex = 1;
			this.PortSpeed.Text = "115200";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 23);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 17);
			this.label2.TabIndex = 16;
			this.label2.Text = "Command";
			// 
			// ReloadBtn
			// 
			this.ReloadBtn.Image = global::CNCGUI.Properties.Resources.reload;
			this.ReloadBtn.Location = new System.Drawing.Point(202, 45);
			this.ReloadBtn.Margin = new System.Windows.Forms.Padding(4);
			this.ReloadBtn.Name = "ReloadBtn";
			this.ReloadBtn.Size = new System.Drawing.Size(32, 30);
			this.ReloadBtn.TabIndex = 5;
			this.ReloadBtn.UseVisualStyleBackColor = true;
			this.ReloadBtn.Click += new System.EventHandler(this.ReloadBtn_Click);
			// 
			// speedOverrideNumber
			// 
			this.speedOverrideNumber.Location = new System.Drawing.Point(162, 60);
			this.speedOverrideNumber.Margin = new System.Windows.Forms.Padding(4);
			this.speedOverrideNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.speedOverrideNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.speedOverrideNumber.Name = "speedOverrideNumber";
			this.speedOverrideNumber.Size = new System.Drawing.Size(88, 22);
			this.speedOverrideNumber.TabIndex = 18;
			this.speedOverrideNumber.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
			// 
			// overrideSpeedChkbox
			// 
			this.overrideSpeedChkbox.AutoSize = true;
			this.overrideSpeedChkbox.Location = new System.Drawing.Point(258, 64);
			this.overrideSpeedChkbox.Margin = new System.Windows.Forms.Padding(4);
			this.overrideSpeedChkbox.Name = "overrideSpeedChkbox";
			this.overrideSpeedChkbox.Size = new System.Drawing.Size(128, 21);
			this.overrideSpeedChkbox.TabIndex = 17;
			this.overrideSpeedChkbox.Text = "Override speed";
			this.overrideSpeedChkbox.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 8);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 17);
			this.label1.TabIndex = 15;
			this.label1.Text = "File";
			// 
			// SettingsBtn
			// 
			this.SettingsBtn.Enabled = false;
			this.SettingsBtn.Location = new System.Drawing.Point(543, 88);
			this.SettingsBtn.Margin = new System.Windows.Forms.Padding(4);
			this.SettingsBtn.Name = "SettingsBtn";
			this.SettingsBtn.Size = new System.Drawing.Size(100, 30);
			this.SettingsBtn.TabIndex = 19;
			this.SettingsBtn.Text = "Save";
			this.SettingsBtn.UseVisualStyleBackColor = true;
			this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status});
			this.statusStrip1.Location = new System.Drawing.Point(0, 578);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1182, 22);
			this.statusStrip1.TabIndex = 20;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// Status
			// 
			this.Status.Name = "Status";
			this.Status.Size = new System.Drawing.Size(1167, 17);
			this.Status.Spring = true;
			this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ControlTabs
			// 
			this.ControlTabs.Controls.Add(this.PageSettings);
			this.ControlTabs.Controls.Add(this.PageMotors);
			this.ControlTabs.Controls.Add(this.PageAxises);
			this.ControlTabs.Controls.Add(this.Page1);
			this.ControlTabs.Controls.Add(this.Page2);
			this.ControlTabs.Enabled = false;
			this.ControlTabs.Location = new System.Drawing.Point(8, 131);
			this.ControlTabs.Name = "ControlTabs";
			this.ControlTabs.SelectedIndex = 0;
			this.ControlTabs.Size = new System.Drawing.Size(639, 444);
			this.ControlTabs.TabIndex = 21;
			// 
			// PageSettings
			// 
			this.PageSettings.Controls.Add(this.label26);
			this.PageSettings.Controls.Add(this.BAUD);
			this.PageSettings.Controls.Add(this.label25);
			this.PageSettings.Controls.Add(this.label24);
			this.PageSettings.Controls.Add(this.GDI);
			this.PageSettings.Controls.Add(this.label23);
			this.PageSettings.Controls.Add(this.GPA);
			this.PageSettings.Controls.Add(this.label22);
			this.PageSettings.Controls.Add(this.GCO);
			this.PageSettings.Controls.Add(this.label21);
			this.PageSettings.Controls.Add(this.GUN);
			this.PageSettings.Controls.Add(this.label20);
			this.PageSettings.Controls.Add(this.GPL);
			this.PageSettings.Controls.Add(this.label19);
			this.PageSettings.Controls.Add(this.label18);
			this.PageSettings.Controls.Add(this.EE);
			this.PageSettings.Controls.Add(this.EC);
			this.PageSettings.Controls.Add(this.label17);
			this.PageSettings.Controls.Add(this.IC);
			this.PageSettings.Controls.Add(this.label16);
			this.PageSettings.Controls.Add(this.SI);
			this.PageSettings.Controls.Add(this.label15);
			this.PageSettings.Controls.Add(this.EX);
			this.PageSettings.Controls.Add(this.label14);
			this.PageSettings.Controls.Add(this.SV);
			this.PageSettings.Controls.Add(this.label13);
			this.PageSettings.Controls.Add(this.QV);
			this.PageSettings.Controls.Add(this.label12);
			this.PageSettings.Controls.Add(this.TV);
			this.PageSettings.Controls.Add(this.label11);
			this.PageSettings.Controls.Add(this.JV);
			this.PageSettings.Controls.Add(this.label10);
			this.PageSettings.Controls.Add(this.EJ);
			this.PageSettings.Controls.Add(this.label9);
			this.PageSettings.Controls.Add(this.ST);
			this.PageSettings.Controls.Add(this.CT);
			this.PageSettings.Controls.Add(this.JA);
			this.PageSettings.Controls.Add(this.label8);
			this.PageSettings.Controls.Add(this.label7);
			this.PageSettings.Controls.Add(this.label6);
			this.PageSettings.Controls.Add(this.InfoID);
			this.PageSettings.Controls.Add(this.label5);
			this.PageSettings.Controls.Add(this.InfoHwVersion);
			this.PageSettings.Controls.Add(this.label4);
			this.PageSettings.Controls.Add(this.InfoFwVersion);
			this.PageSettings.Controls.Add(this.InfoFwBuild);
			this.PageSettings.Controls.Add(this.label3);
			this.PageSettings.Location = new System.Drawing.Point(4, 25);
			this.PageSettings.Name = "PageSettings";
			this.PageSettings.Size = new System.Drawing.Size(631, 415);
			this.PageSettings.TabIndex = 2;
			this.PageSettings.Text = "Settings";
			this.PageSettings.UseVisualStyleBackColor = true;
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(199, 268);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(59, 23);
			this.label26.TabIndex = 49;
			this.label26.Text = "BAUD";
			this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label26, "USB Baud Rate");
			// 
			// BAUD
			// 
			this.BAUD.FormattingEnabled = true;
			this.BAUD.Location = new System.Drawing.Point(263, 268);
			this.BAUD.Name = "BAUD";
			this.BAUD.Size = new System.Drawing.Size(121, 24);
			this.BAUD.TabIndex = 48;
			this.BAUD.Text = "";
			this.toolTip.SetToolTip(this.BAUD, "USB Baud Rate");
			this.BAUD.ValueChanged += new System.EventHandler(this.Setting_Changed);
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(350, 238);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(40, 23);
			this.label25.TabIndex = 47;
			this.label25.Text = "ms";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(447, 268);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(40, 23);
			this.label24.TabIndex = 46;
			this.label24.Text = "GDI";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label24, "Default Gcode Distance Mode");
			// 
			// GDI
			// 
			this.GDI.FormattingEnabled = true;
			this.GDI.Location = new System.Drawing.Point(493, 268);
			this.GDI.Name = "GDI";
			this.GDI.Size = new System.Drawing.Size(121, 24);
			this.GDI.TabIndex = 45;
			this.GDI.Text = "";
			this.toolTip.SetToolTip(this.GDI, "Default Gcode Distance Mode");
			this.GDI.ValueChanged += new System.EventHandler(this.Setting_Changed);
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(447, 238);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(40, 23);
			this.label23.TabIndex = 44;
			this.label23.Text = "GPA";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label23, "Default Gcode Path Control");
			// 
			// GPA
			// 
			this.GPA.FormattingEnabled = true;
			this.GPA.Location = new System.Drawing.Point(493, 238);
			this.GPA.Name = "GPA";
			this.GPA.Size = new System.Drawing.Size(121, 24);
			this.GPA.TabIndex = 43;
			this.GPA.Text = "";
			this.toolTip.SetToolTip(this.GPA, "Default Gcode Path Control");
			this.GPA.ValueChanged += new System.EventHandler(this.Setting_Changed);
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(447, 208);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(40, 23);
			this.label22.TabIndex = 42;
			this.label22.Text = "GCO";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label22, "Default Gcode Coord System");
			// 
			// GCO
			// 
			this.GCO.FormattingEnabled = true;
			this.GCO.Location = new System.Drawing.Point(493, 208);
			this.GCO.Name = "GCO";
			this.GCO.Size = new System.Drawing.Size(121, 24);
			this.GCO.TabIndex = 41;
			this.GCO.Text = "";
			this.toolTip.SetToolTip(this.GCO, "Default Gcode Coord System");
			this.GCO.ValueChanged += new System.EventHandler(this.Setting_Changed);
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(447, 178);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(40, 23);
			this.label21.TabIndex = 40;
			this.label21.Text = "GUN";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label21, "Default Gcode Units Mode");
			// 
			// GUN
			// 
			this.GUN.FormattingEnabled = true;
			this.GUN.Location = new System.Drawing.Point(493, 178);
			this.GUN.Name = "GUN";
			this.GUN.Size = new System.Drawing.Size(121, 24);
			this.GUN.TabIndex = 39;
			this.GUN.Text = "";
			this.toolTip.SetToolTip(this.GUN, "Default Gcode Units Mode");
			this.GUN.ValueChanged += new System.EventHandler(this.Setting_Changed);
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(447, 148);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(40, 23);
			this.label20.TabIndex = 38;
			this.label20.Text = "GPL";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label20, "Default Gcode Plane");
			// 
			// GPL
			// 
			this.GPL.FormattingEnabled = true;
			this.GPL.Location = new System.Drawing.Point(493, 148);
			this.GPL.Name = "GPL";
			this.GPL.Size = new System.Drawing.Size(121, 24);
			this.GPL.TabIndex = 37;
			this.GPL.Text = "";
			this.toolTip.SetToolTip(this.GPL, "Default Gcode Plane");
			this.GPL.ValueChanged += new System.EventHandler(this.Setting_Changed);
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(447, 63);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(40, 23);
			this.label19.TabIndex = 36;
			this.label19.Text = "EE";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label19, "Enable Echo");
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(447, 35);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(40, 23);
			this.label18.TabIndex = 35;
			this.label18.Text = "EC";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label18, "Expand LF to CRLF on TX");
			// 
			// EE
			// 
			this.EE.FormattingEnabled = true;
			this.EE.Location = new System.Drawing.Point(493, 63);
			this.EE.Name = "EE";
			this.EE.Size = new System.Drawing.Size(121, 24);
			this.EE.TabIndex = 34;
			this.EE.Text = "";
			this.toolTip.SetToolTip(this.EE, "Enable Echo");
			this.EE.ValueChanged += new System.EventHandler(this.Setting_Changed);
			// 
			// EC
			// 
			this.EC.FormattingEnabled = true;
			this.EC.Location = new System.Drawing.Point(493, 35);
			this.EC.Name = "EC";
			this.EC.Size = new System.Drawing.Size(121, 24);
			this.EC.TabIndex = 33;
			this.EC.Text = "";
			this.toolTip.SetToolTip(this.EC, "Expand LF to CRLF on TX");
			this.EC.ValueChanged += new System.EventHandler(this.Setting_Changed);
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(447, 7);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(40, 23);
			this.label17.TabIndex = 32;
			this.label17.Text = "IC";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label17, "Ignore CR or LF on RX");
			// 
			// IC
			// 
			this.IC.FormattingEnabled = true;
			this.IC.Location = new System.Drawing.Point(493, 7);
			this.IC.Name = "IC";
			this.IC.Size = new System.Drawing.Size(121, 24);
			this.IC.TabIndex = 31;
			this.IC.Text = "";
			this.toolTip.SetToolTip(this.IC, "Ignore CR or LF on RX");
			this.IC.ValueChanged += new System.EventHandler(this.Setting_Changed);
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(218, 238);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(40, 23);
			this.label16.TabIndex = 30;
			this.label16.Text = "SI";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label16, "Status Interval");
			// 
			// SI
			// 
			this.SI.Location = new System.Drawing.Point(264, 238);
			this.SI.Name = "SI";
			this.SI.Size = new System.Drawing.Size(80, 22);
			this.SI.TabIndex = 29;
			this.SI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolTip.SetToolTip(this.SI, "Status Interval");
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(447, 90);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(40, 23);
			this.label15.TabIndex = 28;
			this.label15.Text = "EX";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label15, "Enable XON/XOFF");
			// 
			// EX
			// 
			this.EX.FormattingEnabled = true;
			this.EX.Location = new System.Drawing.Point(493, 90);
			this.EX.Name = "EX";
			this.EX.Size = new System.Drawing.Size(121, 24);
			this.EX.TabIndex = 27;
			this.EX.Text = "";
			this.toolTip.SetToolTip(this.EX, "Enable XON/XOFF");
			this.EX.ValueChanged += new System.EventHandler(this.Setting_Changed);
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(218, 209);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(40, 23);
			this.label14.TabIndex = 26;
			this.label14.Text = "SV";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label14, "Status Report Verbosity");
			// 
			// SV
			// 
			this.SV.FormattingEnabled = true;
			this.SV.Location = new System.Drawing.Point(263, 208);
			this.SV.Name = "SV";
			this.SV.Size = new System.Drawing.Size(121, 24);
			this.SV.TabIndex = 25;
			this.SV.Text = "";
			this.toolTip.SetToolTip(this.SV, "Status Report Verbosity");
			this.SV.ValueChanged += new System.EventHandler(this.Setting_Changed);
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(218, 179);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(40, 23);
			this.label13.TabIndex = 24;
			this.label13.Text = "QV";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// QV
			// 
			this.QV.FormattingEnabled = true;
			this.QV.Location = new System.Drawing.Point(263, 178);
			this.QV.Name = "QV";
			this.QV.Size = new System.Drawing.Size(121, 24);
			this.QV.TabIndex = 23;
			this.QV.Text = "";
			this.toolTip.SetToolTip(this.QV, "Queue Report Verbosity");
			this.QV.ValueChanged += new System.EventHandler(this.Setting_Changed);
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(218, 149);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(40, 23);
			this.label12.TabIndex = 22;
			this.label12.Text = "TV";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TV
			// 
			this.TV.FormattingEnabled = true;
			this.TV.Location = new System.Drawing.Point(264, 148);
			this.TV.Name = "TV";
			this.TV.Size = new System.Drawing.Size(121, 24);
			this.TV.TabIndex = 21;
			this.TV.Text = "";
			this.toolTip.SetToolTip(this.TV, "Text Verbosity");
			this.TV.ValueChanged += new System.EventHandler(this.Setting_Changed);
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(218, 118);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(40, 23);
			this.label11.TabIndex = 19;
			this.label11.Text = "JV";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// JV
			// 
			this.JV.FormattingEnabled = true;
			this.JV.Location = new System.Drawing.Point(263, 118);
			this.JV.Name = "JV";
			this.JV.Size = new System.Drawing.Size(121, 24);
			this.JV.TabIndex = 18;
			this.JV.Text = "";
			this.toolTip.SetToolTip(this.JV, "Json Verbosity");
			this.JV.ValueChanged += new System.EventHandler(this.Setting_Changed);
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(218, 90);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(40, 23);
			this.label10.TabIndex = 17;
			this.label10.Text = "EJ";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// EJ
			// 
			this.EJ.FormattingEnabled = true;
			this.EJ.Location = new System.Drawing.Point(263, 90);
			this.EJ.Name = "EJ";
			this.EJ.Size = new System.Drawing.Size(121, 24);
			this.EJ.TabIndex = 16;
			this.EJ.Text = "";
			this.toolTip.SetToolTip(this.EJ, "Json Mode Enable");
			this.EJ.ValueChanged += new System.EventHandler(this.Setting_Changed);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(218, 63);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 23);
			this.label9.TabIndex = 15;
			this.label9.Text = "ST";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ST
			// 
			this.ST.FormattingEnabled = true;
			this.ST.Location = new System.Drawing.Point(263, 63);
			this.ST.Name = "ST";
			this.ST.Size = new System.Drawing.Size(121, 24);
			this.ST.TabIndex = 14;
			this.ST.Text = "";
			this.toolTip.SetToolTip(this.ST, "Switch Type");
			this.ST.ValueChanged += new System.EventHandler(this.Setting_Changed);
			// 
			// CT
			// 
			this.CT.Location = new System.Drawing.Point(264, 35);
			this.CT.Name = "CT";
			this.CT.Size = new System.Drawing.Size(120, 24);
			this.CT.TabIndex = 13;
			this.CT.ValueChanged += new System.EventHandler(this.Setting_Changed);
			// 
			// JA
			// 
			this.JA.Location = new System.Drawing.Point(264, 7);
			this.JA.Name = "JA";
			this.JA.Size = new System.Drawing.Size(120, 24);
			this.JA.TabIndex = 12;
			this.JA.ValueChanged += new System.EventHandler(this.Setting_Changed);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(218, 35);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 23);
			this.label8.TabIndex = 11;
			this.label8.Text = "CT";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(218, 7);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 23);
			this.label7.TabIndex = 8;
			this.label7.Text = "JA";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 90);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 7;
			this.label6.Text = "ID";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// InfoID
			// 
			this.InfoID.Location = new System.Drawing.Point(112, 90);
			this.InfoID.Name = "InfoID";
			this.InfoID.ReadOnly = true;
			this.InfoID.Size = new System.Drawing.Size(100, 22);
			this.InfoID.TabIndex = 6;
			this.InfoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 63);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "HW Version";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// InfoHwVersion
			// 
			this.InfoHwVersion.Location = new System.Drawing.Point(112, 63);
			this.InfoHwVersion.Name = "InfoHwVersion";
			this.InfoHwVersion.ReadOnly = true;
			this.InfoHwVersion.Size = new System.Drawing.Size(100, 22);
			this.InfoHwVersion.TabIndex = 4;
			this.InfoHwVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "FW Version";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// InfoFwVersion
			// 
			this.InfoFwVersion.Location = new System.Drawing.Point(112, 35);
			this.InfoFwVersion.Name = "InfoFwVersion";
			this.InfoFwVersion.ReadOnly = true;
			this.InfoFwVersion.Size = new System.Drawing.Size(100, 22);
			this.InfoFwVersion.TabIndex = 2;
			this.InfoFwVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// InfoFwBuild
			// 
			this.InfoFwBuild.Location = new System.Drawing.Point(112, 7);
			this.InfoFwBuild.Name = "InfoFwBuild";
			this.InfoFwBuild.ReadOnly = true;
			this.InfoFwBuild.Size = new System.Drawing.Size(100, 22);
			this.InfoFwBuild.TabIndex = 1;
			this.InfoFwBuild.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "FW Build";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// PageMotors
			// 
			this.PageMotors.Controls.Add(this.Motor4);
			this.PageMotors.Controls.Add(this.Motor3);
			this.PageMotors.Controls.Add(this.Motor2);
			this.PageMotors.Controls.Add(this.Motor1);
			this.PageMotors.Location = new System.Drawing.Point(4, 25);
			this.PageMotors.Name = "PageMotors";
			this.PageMotors.Size = new System.Drawing.Size(631, 415);
			this.PageMotors.TabIndex = 3;
			this.PageMotors.Text = "Motors";
			this.PageMotors.UseVisualStyleBackColor = true;
			// 
			// Motor4
			// 
			this.Motor4.Caption = "Motor 4";
			this.Motor4.Location = new System.Drawing.Point(475, 6);
			this.Motor4.Motor = null;
			this.Motor4.Name = "Motor4";
			this.Motor4.Size = new System.Drawing.Size(150, 292);
			this.Motor4.TabIndex = 3;
			this.Motor4.ValueChanged += new System.EventHandler(this.Setting_Changed);
			// 
			// Motor3
			// 
			this.Motor3.Caption = "Motor 3";
			this.Motor3.Location = new System.Drawing.Point(318, 6);
			this.Motor3.Motor = null;
			this.Motor3.Name = "Motor3";
			this.Motor3.Size = new System.Drawing.Size(150, 292);
			this.Motor3.TabIndex = 2;
			this.Motor3.ValueChanged += new System.EventHandler(this.Setting_Changed);
			// 
			// Motor2
			// 
			this.Motor2.Caption = "Motor 2";
			this.Motor2.Location = new System.Drawing.Point(162, 6);
			this.Motor2.Motor = null;
			this.Motor2.Name = "Motor2";
			this.Motor2.Size = new System.Drawing.Size(150, 292);
			this.Motor2.TabIndex = 1;
			this.Motor2.ValueChanged += new System.EventHandler(this.Setting_Changed);
			// 
			// Motor1
			// 
			this.Motor1.Caption = "Motor 1";
			this.Motor1.Location = new System.Drawing.Point(6, 6);
			this.Motor1.Motor = null;
			this.Motor1.Name = "Motor1";
			this.Motor1.Size = new System.Drawing.Size(150, 292);
			this.Motor1.TabIndex = 0;
			this.Motor1.ValueChanged += new System.EventHandler(this.Setting_Changed);
			// 
			// PageAxises
			// 
			this.PageAxises.Controls.Add(this.AxisA);
			this.PageAxises.Controls.Add(this.AxisZ);
			this.PageAxises.Controls.Add(this.AxisY);
			this.PageAxises.Controls.Add(this.AxisX);
			this.PageAxises.Location = new System.Drawing.Point(4, 25);
			this.PageAxises.Name = "PageAxises";
			this.PageAxises.Size = new System.Drawing.Size(631, 415);
			this.PageAxises.TabIndex = 4;
			this.PageAxises.Text = "Axises";
			this.PageAxises.UseVisualStyleBackColor = true;
			// 
			// AxisA
			// 
			this.AxisA.Axis = null;
			this.AxisA.Caption = "A";
			this.AxisA.Location = new System.Drawing.Point(474, 6);
			this.AxisA.Name = "AxisA";
			this.AxisA.Size = new System.Drawing.Size(150, 391);
			this.AxisA.TabIndex = 3;
			// 
			// AxisZ
			// 
			this.AxisZ.Axis = null;
			this.AxisZ.Caption = "Z";
			this.AxisZ.Location = new System.Drawing.Point(318, 6);
			this.AxisZ.Name = "AxisZ";
			this.AxisZ.Size = new System.Drawing.Size(150, 391);
			this.AxisZ.TabIndex = 2;
			// 
			// AxisY
			// 
			this.AxisY.Axis = null;
			this.AxisY.Caption = "Y";
			this.AxisY.Location = new System.Drawing.Point(162, 6);
			this.AxisY.Name = "AxisY";
			this.AxisY.Size = new System.Drawing.Size(150, 391);
			this.AxisY.TabIndex = 1;
			// 
			// AxisX
			// 
			this.AxisX.Axis = null;
			this.AxisX.Caption = "X";
			this.AxisX.Location = new System.Drawing.Point(6, 6);
			this.AxisX.Name = "AxisX";
			this.AxisX.Size = new System.Drawing.Size(150, 391);
			this.AxisX.TabIndex = 0;
			// 
			// Page1
			// 
			this.Page1.Controls.Add(this.label31);
			this.Page1.Controls.Add(this.CurrentA);
			this.Page1.Controls.Add(this.label30);
			this.Page1.Controls.Add(this.label29);
			this.Page1.Controls.Add(this.label28);
			this.Page1.Controls.Add(this.CurrentZ);
			this.Page1.Controls.Add(this.CurrentY);
			this.Page1.Controls.Add(this.CurrentX);
			this.Page1.Controls.Add(this.MoveStep);
			this.Page1.Controls.Add(this.MoveYMXM);
			this.Page1.Controls.Add(this.MoveYPXM);
			this.Page1.Controls.Add(this.MoveYMXP);
			this.Page1.Controls.Add(this.MoveYPXP);
			this.Page1.Controls.Add(this.MoveZM);
			this.Page1.Controls.Add(this.MoveZP);
			this.Page1.Controls.Add(this.MoveHome);
			this.Page1.Controls.Add(this.MoveYM);
			this.Page1.Controls.Add(this.MoveYP);
			this.Page1.Controls.Add(this.MoveXM);
			this.Page1.Controls.Add(this.MoveXP);
			this.Page1.Location = new System.Drawing.Point(4, 25);
			this.Page1.Name = "Page1";
			this.Page1.Padding = new System.Windows.Forms.Padding(3);
			this.Page1.Size = new System.Drawing.Size(631, 415);
			this.Page1.TabIndex = 1;
			this.Page1.Text = "Manual";
			this.Page1.UseVisualStyleBackColor = true;
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Location = new System.Drawing.Point(508, 88);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(17, 17);
			this.label31.TabIndex = 20;
			this.label31.Text = "A";
			this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// CurrentA
			// 
			this.CurrentA.Location = new System.Drawing.Point(531, 85);
			this.CurrentA.Name = "CurrentA";
			this.CurrentA.ReadOnly = true;
			this.CurrentA.Size = new System.Drawing.Size(97, 22);
			this.CurrentA.TabIndex = 19;
			this.CurrentA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(507, 61);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(17, 17);
			this.label30.TabIndex = 18;
			this.label30.Text = "Z";
			this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(507, 35);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(17, 17);
			this.label29.TabIndex = 17;
			this.label29.Text = "Y";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(507, 9);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(17, 17);
			this.label28.TabIndex = 16;
			this.label28.Text = "X";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// CurrentZ
			// 
			this.CurrentZ.Location = new System.Drawing.Point(531, 58);
			this.CurrentZ.Name = "CurrentZ";
			this.CurrentZ.ReadOnly = true;
			this.CurrentZ.Size = new System.Drawing.Size(97, 22);
			this.CurrentZ.TabIndex = 15;
			this.CurrentZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// CurrentY
			// 
			this.CurrentY.Location = new System.Drawing.Point(531, 32);
			this.CurrentY.Name = "CurrentY";
			this.CurrentY.ReadOnly = true;
			this.CurrentY.Size = new System.Drawing.Size(97, 22);
			this.CurrentY.TabIndex = 14;
			this.CurrentY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// CurrentX
			// 
			this.CurrentX.Location = new System.Drawing.Point(531, 6);
			this.CurrentX.Name = "CurrentX";
			this.CurrentX.ReadOnly = true;
			this.CurrentX.Size = new System.Drawing.Size(97, 22);
			this.CurrentX.TabIndex = 13;
			this.CurrentX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// MoveStep
			// 
			this.MoveStep.DecimalPlaces = 3;
			this.MoveStep.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.MoveStep.Location = new System.Drawing.Point(6, 6);
			this.MoveStep.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.MoveStep.Name = "MoveStep";
			this.MoveStep.Size = new System.Drawing.Size(76, 22);
			this.MoveStep.TabIndex = 12;
			this.MoveStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.MoveStep.ThousandsSeparator = true;
			this.MoveStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// MoveYMXM
			// 
			this.MoveYMXM.Location = new System.Drawing.Point(130, 118);
			this.MoveYMXM.Name = "MoveYMXM";
			this.MoveYMXM.Size = new System.Drawing.Size(56, 56);
			this.MoveYMXM.TabIndex = 11;
			this.MoveYMXM.UseVisualStyleBackColor = true;
			this.MoveYMXM.Click += new System.EventHandler(this.MoveYMXM_Click);
			// 
			// MoveYPXM
			// 
			this.MoveYPXM.Location = new System.Drawing.Point(130, 6);
			this.MoveYPXM.Name = "MoveYPXM";
			this.MoveYPXM.Size = new System.Drawing.Size(56, 56);
			this.MoveYPXM.TabIndex = 10;
			this.MoveYPXM.UseVisualStyleBackColor = true;
			this.MoveYPXM.Click += new System.EventHandler(this.MoveYPXM_Click);
			// 
			// MoveYMXP
			// 
			this.MoveYMXP.Location = new System.Drawing.Point(242, 118);
			this.MoveYMXP.Name = "MoveYMXP";
			this.MoveYMXP.Size = new System.Drawing.Size(56, 56);
			this.MoveYMXP.TabIndex = 9;
			this.MoveYMXP.UseVisualStyleBackColor = true;
			this.MoveYMXP.Click += new System.EventHandler(this.MoveYMXP_Click);
			// 
			// MoveYPXP
			// 
			this.MoveYPXP.Location = new System.Drawing.Point(242, 6);
			this.MoveYPXP.Name = "MoveYPXP";
			this.MoveYPXP.Size = new System.Drawing.Size(56, 56);
			this.MoveYPXP.TabIndex = 8;
			this.MoveYPXP.UseVisualStyleBackColor = true;
			this.MoveYPXP.Click += new System.EventHandler(this.MoveYPXP_Click);
			// 
			// MoveZM
			// 
			this.MoveZM.Location = new System.Drawing.Point(330, 118);
			this.MoveZM.Name = "MoveZM";
			this.MoveZM.Size = new System.Drawing.Size(56, 56);
			this.MoveZM.TabIndex = 6;
			this.MoveZM.Text = "-Z";
			this.MoveZM.UseVisualStyleBackColor = true;
			this.MoveZM.Click += new System.EventHandler(this.MoveZM_Click);
			// 
			// MoveZP
			// 
			this.MoveZP.Location = new System.Drawing.Point(330, 6);
			this.MoveZP.Name = "MoveZP";
			this.MoveZP.Size = new System.Drawing.Size(56, 56);
			this.MoveZP.TabIndex = 5;
			this.MoveZP.Text = "Z+";
			this.MoveZP.UseVisualStyleBackColor = true;
			this.MoveZP.Click += new System.EventHandler(this.MoveZP_Click);
			// 
			// MoveHome
			// 
			this.MoveHome.Location = new System.Drawing.Point(186, 62);
			this.MoveHome.Name = "MoveHome";
			this.MoveHome.Size = new System.Drawing.Size(56, 56);
			this.MoveHome.TabIndex = 0;
			this.MoveHome.Text = "Home";
			this.MoveHome.UseVisualStyleBackColor = true;
			this.MoveHome.Click += new System.EventHandler(this.MoveHome_Click);
			// 
			// MoveYM
			// 
			this.MoveYM.Image = global::CNCGUI.Properties.Resources.down;
			this.MoveYM.Location = new System.Drawing.Point(186, 118);
			this.MoveYM.Name = "MoveYM";
			this.MoveYM.Size = new System.Drawing.Size(56, 56);
			this.MoveYM.TabIndex = 4;
			this.MoveYM.UseVisualStyleBackColor = true;
			this.MoveYM.Click += new System.EventHandler(this.MoveYM_Click);
			// 
			// MoveYP
			// 
			this.MoveYP.Image = global::CNCGUI.Properties.Resources.up;
			this.MoveYP.Location = new System.Drawing.Point(186, 6);
			this.MoveYP.Name = "MoveYP";
			this.MoveYP.Size = new System.Drawing.Size(56, 56);
			this.MoveYP.TabIndex = 3;
			this.MoveYP.UseVisualStyleBackColor = true;
			this.MoveYP.Click += new System.EventHandler(this.MoveYP_Click);
			// 
			// MoveXM
			// 
			this.MoveXM.Image = global::CNCGUI.Properties.Resources.back;
			this.MoveXM.Location = new System.Drawing.Point(130, 62);
			this.MoveXM.Name = "MoveXM";
			this.MoveXM.Size = new System.Drawing.Size(56, 56);
			this.MoveXM.TabIndex = 2;
			this.MoveXM.UseVisualStyleBackColor = true;
			this.MoveXM.Click += new System.EventHandler(this.MoveXM_Click);
			// 
			// MoveXP
			// 
			this.MoveXP.Image = global::CNCGUI.Properties.Resources.forward;
			this.MoveXP.Location = new System.Drawing.Point(242, 62);
			this.MoveXP.Name = "MoveXP";
			this.MoveXP.Size = new System.Drawing.Size(56, 56);
			this.MoveXP.TabIndex = 1;
			this.MoveXP.UseVisualStyleBackColor = true;
			this.MoveXP.Click += new System.EventHandler(this.MoveXP_Click);
			// 
			// Page2
			// 
			this.Page2.Controls.Add(this.label32);
			this.Page2.Controls.Add(this.CurrentA2);
			this.Page2.Controls.Add(this.label33);
			this.Page2.Controls.Add(this.label34);
			this.Page2.Controls.Add(this.label35);
			this.Page2.Controls.Add(this.CurrentZ2);
			this.Page2.Controls.Add(this.CurrentY2);
			this.Page2.Controls.Add(this.CurrentX2);
			this.Page2.Controls.Add(this.IgnoreGCodeErrors);
			this.Page2.Controls.Add(this.speedOverrideNumber);
			this.Page2.Controls.Add(this.FileName);
			this.Page2.Controls.Add(this.overrideSpeedChkbox);
			this.Page2.Controls.Add(this.SentRowsLbl);
			this.Page2.Controls.Add(this.label1);
			this.Page2.Controls.Add(this.RowsInFileLbl);
			this.Page2.Controls.Add(this.Stop_Btn);
			this.Page2.Controls.Add(this.Load_Btn);
			this.Page2.Controls.Add(this.Send_Btn);
			this.Page2.Location = new System.Drawing.Point(4, 25);
			this.Page2.Name = "Page2";
			this.Page2.Padding = new System.Windows.Forms.Padding(3);
			this.Page2.Size = new System.Drawing.Size(631, 415);
			this.Page2.TabIndex = 0;
			this.Page2.Text = "File Transfer";
			this.Page2.UseVisualStyleBackColor = true;
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Location = new System.Drawing.Point(505, 87);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(17, 17);
			this.label32.TabIndex = 28;
			this.label32.Text = "A";
			this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// CurrentA2
			// 
			this.CurrentA2.Location = new System.Drawing.Point(528, 84);
			this.CurrentA2.Name = "CurrentA2";
			this.CurrentA2.ReadOnly = true;
			this.CurrentA2.Size = new System.Drawing.Size(97, 22);
			this.CurrentA2.TabIndex = 27;
			this.CurrentA2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Location = new System.Drawing.Point(504, 60);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(17, 17);
			this.label33.TabIndex = 26;
			this.label33.Text = "Z";
			this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.Location = new System.Drawing.Point(504, 34);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(17, 17);
			this.label34.TabIndex = 25;
			this.label34.Text = "Y";
			this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label35
			// 
			this.label35.AutoSize = true;
			this.label35.Location = new System.Drawing.Point(504, 8);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(17, 17);
			this.label35.TabIndex = 24;
			this.label35.Text = "X";
			this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// CurrentZ2
			// 
			this.CurrentZ2.Location = new System.Drawing.Point(528, 57);
			this.CurrentZ2.Name = "CurrentZ2";
			this.CurrentZ2.ReadOnly = true;
			this.CurrentZ2.Size = new System.Drawing.Size(97, 22);
			this.CurrentZ2.TabIndex = 23;
			this.CurrentZ2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// CurrentY2
			// 
			this.CurrentY2.Location = new System.Drawing.Point(528, 31);
			this.CurrentY2.Name = "CurrentY2";
			this.CurrentY2.ReadOnly = true;
			this.CurrentY2.Size = new System.Drawing.Size(97, 22);
			this.CurrentY2.TabIndex = 22;
			this.CurrentY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// CurrentX2
			// 
			this.CurrentX2.Location = new System.Drawing.Point(528, 5);
			this.CurrentX2.Name = "CurrentX2";
			this.CurrentX2.ReadOnly = true;
			this.CurrentX2.Size = new System.Drawing.Size(97, 22);
			this.CurrentX2.TabIndex = 21;
			this.CurrentX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// IgnoreGCodeErrors
			// 
			this.IgnoreGCodeErrors.AutoSize = true;
			this.IgnoreGCodeErrors.Location = new System.Drawing.Point(258, 93);
			this.IgnoreGCodeErrors.Margin = new System.Windows.Forms.Padding(4);
			this.IgnoreGCodeErrors.Name = "IgnoreGCodeErrors";
			this.IgnoreGCodeErrors.Size = new System.Drawing.Size(160, 21);
			this.IgnoreGCodeErrors.TabIndex = 19;
			this.IgnoreGCodeErrors.Text = "Ignore GCode errors";
			this.IgnoreGCodeErrors.UseVisualStyleBackColor = true;
			// 
			// UseResponseItems
			// 
			this.UseResponseItems.AutoSize = true;
			this.UseResponseItems.Checked = true;
			this.UseResponseItems.CheckState = System.Windows.Forms.CheckState.Checked;
			this.UseResponseItems.Location = new System.Drawing.Point(349, 125);
			this.UseResponseItems.Name = "UseResponseItems";
			this.UseResponseItems.Size = new System.Drawing.Size(187, 21);
			this.UseResponseItems.TabIndex = 20;
			this.UseResponseItems.Text = "Use items from response";
			this.UseResponseItems.UseVisualStyleBackColor = true;
			this.UseResponseItems.CheckedChanged += new System.EventHandler(this.UseResponseItems_CheckedChanged);
			// 
			// RefreshBtn
			// 
			this.RefreshBtn.Location = new System.Drawing.Point(543, 119);
			this.RefreshBtn.Margin = new System.Windows.Forms.Padding(4);
			this.RefreshBtn.Name = "RefreshBtn";
			this.RefreshBtn.Size = new System.Drawing.Size(100, 30);
			this.RefreshBtn.TabIndex = 50;
			this.RefreshBtn.Text = "Refresh";
			this.RefreshBtn.UseVisualStyleBackColor = true;
			this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
			// 
			// ClearBtn
			// 
			this.ClearBtn.Location = new System.Drawing.Point(543, 12);
			this.ClearBtn.Margin = new System.Windows.Forms.Padding(4);
			this.ClearBtn.Name = "ClearBtn";
			this.ClearBtn.Size = new System.Drawing.Size(100, 30);
			this.ClearBtn.TabIndex = 51;
			this.ClearBtn.Text = "Clear";
			this.ClearBtn.UseVisualStyleBackColor = true;
			this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
			// 
			// backgroundWorker
			// 
			this.backgroundWorker.WorkerReportsProgress = true;
			this.backgroundWorker.WorkerSupportsCancellation = true;
			this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
			this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
			this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
			// 
			// TabLogGraph
			// 
			this.TabLogGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TabLogGraph.Controls.Add(this.PageLog);
			this.TabLogGraph.Controls.Add(this.PageGraph);
			this.TabLogGraph.Controls.Add(this.PageGCode);
			this.TabLogGraph.Location = new System.Drawing.Point(650, 6);
			this.TabLogGraph.Name = "TabLogGraph";
			this.TabLogGraph.SelectedIndex = 0;
			this.TabLogGraph.Size = new System.Drawing.Size(532, 569);
			this.TabLogGraph.TabIndex = 52;
			this.TabLogGraph.SelectedIndexChanged += new System.EventHandler(this.TabLogGraph_SelectedIndexChanged);
			// 
			// PageLog
			// 
			this.PageLog.Controls.Add(this.Log);
			this.PageLog.Location = new System.Drawing.Point(4, 25);
			this.PageLog.Name = "PageLog";
			this.PageLog.Padding = new System.Windows.Forms.Padding(3);
			this.PageLog.Size = new System.Drawing.Size(524, 540);
			this.PageLog.TabIndex = 0;
			this.PageLog.Text = "Log";
			this.PageLog.UseVisualStyleBackColor = true;
			// 
			// Log
			// 
			this.Log.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LogColumn1});
			this.Log.CurrentLine = 0;
			this.Log.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Log.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Log.FullRowSelect = true;
			this.Log.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.Log.Location = new System.Drawing.Point(3, 3);
			this.Log.Margin = new System.Windows.Forms.Padding(4);
			this.Log.Name = "Log";
			this.Log.SavedLine = 0;
			this.Log.Size = new System.Drawing.Size(518, 534);
			this.Log.TabIndex = 15;
			this.Log.UseCompatibleStateImageBehavior = false;
			this.Log.View = System.Windows.Forms.View.Details;
			// 
			// PageGraph
			// 
			this.PageGraph.Controls.Add(this.label27);
			this.PageGraph.Controls.Add(this.ZLevel);
			this.PageGraph.Controls.Add(this.GPlotPicture);
			this.PageGraph.Location = new System.Drawing.Point(4, 25);
			this.PageGraph.Name = "PageGraph";
			this.PageGraph.Padding = new System.Windows.Forms.Padding(3);
			this.PageGraph.Size = new System.Drawing.Size(524, 540);
			this.PageGraph.TabIndex = 1;
			this.PageGraph.Text = "G-Plot";
			this.PageGraph.UseVisualStyleBackColor = true;
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label27.Location = new System.Drawing.Point(6, 8);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(55, 17);
			this.label27.TabIndex = 2;
			this.label27.Text = "Z Level";
			// 
			// ZLevel
			// 
			this.ZLevel.Location = new System.Drawing.Point(66, 6);
			this.ZLevel.Name = "ZLevel";
			this.ZLevel.Size = new System.Drawing.Size(51, 22);
			this.ZLevel.TabIndex = 1;
			this.ZLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// GPlotPicture
			// 
			this.GPlotPicture.BackColor = System.Drawing.Color.Black;
			this.GPlotPicture.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GPlotPicture.Location = new System.Drawing.Point(3, 3);
			this.GPlotPicture.Name = "GPlotPicture";
			this.GPlotPicture.Size = new System.Drawing.Size(518, 534);
			this.GPlotPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.GPlotPicture.TabIndex = 0;
			this.GPlotPicture.TabStop = false;
			// 
			// PageGCode
			// 
			this.PageGCode.Controls.Add(this.GCodes);
			this.PageGCode.Location = new System.Drawing.Point(4, 25);
			this.PageGCode.Name = "PageGCode";
			this.PageGCode.Size = new System.Drawing.Size(524, 540);
			this.PageGCode.TabIndex = 2;
			this.PageGCode.Text = "G-Code";
			this.PageGCode.UseVisualStyleBackColor = true;
			// 
			// GCodes
			// 
			this.GCodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnBP,
            this.columnGCode});
			this.GCodes.ContextMenuStrip = this.GCodeMenu;
			this.GCodes.CurrentLine = 0;
			this.GCodes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GCodes.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.GCodes.FullRowSelect = true;
			this.GCodes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.GCodes.Location = new System.Drawing.Point(0, 0);
			this.GCodes.Margin = new System.Windows.Forms.Padding(4);
			this.GCodes.MultiSelect = false;
			this.GCodes.Name = "GCodes";
			this.GCodes.SavedLine = 0;
			this.GCodes.Size = new System.Drawing.Size(524, 540);
			this.GCodes.SmallImageList = this.GCodeImages;
			this.GCodes.TabIndex = 16;
			this.GCodes.UseCompatibleStateImageBehavior = false;
			this.GCodes.View = System.Windows.Forms.View.Details;
			// 
			// columnBP
			// 
			this.columnBP.Text = "";
			this.columnBP.Width = 24;
			// 
			// columnGCode
			// 
			this.columnGCode.Text = "GCode";
			// 
			// GCodeMenu
			// 
			this.GCodeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_Run,
            this.mi_RunToCursor,
            this.mi_Step,
            this.mi_Stop,
            this.toolStripMenuItem1,
            this.mi_ToggleBP,
            this.mi_DeleteAllBP,
            this.toolStripMenuItem2,
            this.mi_NextCommand});
			this.GCodeMenu.Name = "GCodeMenu";
			this.GCodeMenu.Size = new System.Drawing.Size(311, 206);
			// 
			// mi_Run
			// 
			this.mi_Run.Name = "mi_Run";
			this.mi_Run.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.mi_Run.Size = new System.Drawing.Size(310, 24);
			this.mi_Run.Text = "Start";
			this.mi_Run.Click += new System.EventHandler(this.mi_Run_Click);
			// 
			// mi_Step
			// 
			this.mi_Step.Name = "mi_Step";
			this.mi_Step.ShortcutKeys = System.Windows.Forms.Keys.F10;
			this.mi_Step.Size = new System.Drawing.Size(310, 24);
			this.mi_Step.Text = "Step";
			this.mi_Step.Click += new System.EventHandler(this.mi_Step_Click);
			// 
			// mi_Stop
			// 
			this.mi_Stop.Name = "mi_Stop";
			this.mi_Stop.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F5)));
			this.mi_Stop.Size = new System.Drawing.Size(310, 24);
			this.mi_Stop.Text = "Stop";
			this.mi_Stop.Click += new System.EventHandler(this.mi_Stop_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(307, 6);
			// 
			// mi_ToggleBP
			// 
			this.mi_ToggleBP.Name = "mi_ToggleBP";
			this.mi_ToggleBP.ShortcutKeys = System.Windows.Forms.Keys.F9;
			this.mi_ToggleBP.Size = new System.Drawing.Size(310, 24);
			this.mi_ToggleBP.Text = "Toggle BP";
			this.mi_ToggleBP.Click += new System.EventHandler(this.mi_ToggleBP_Click);
			// 
			// mi_DeleteAllBP
			// 
			this.mi_DeleteAllBP.Name = "mi_DeleteAllBP";
			this.mi_DeleteAllBP.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F9)));
			this.mi_DeleteAllBP.Size = new System.Drawing.Size(310, 24);
			this.mi_DeleteAllBP.Text = "Delete All BP";
			this.mi_DeleteAllBP.Click += new System.EventHandler(this.mi_DeleteAllBP_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(307, 6);
			// 
			// mi_NextCommand
			// 
			this.mi_NextCommand.Name = "mi_NextCommand";
			this.mi_NextCommand.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F10)));
			this.mi_NextCommand.Size = new System.Drawing.Size(310, 24);
			this.mi_NextCommand.Text = "Set Next command";
			this.mi_NextCommand.Click += new System.EventHandler(this.mi_NextCommand_Click);
			// 
			// GCodeImages
			// 
			this.GCodeImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("GCodeImages.ImageStream")));
			this.GCodeImages.TransparentColor = System.Drawing.Color.Transparent;
			this.GCodeImages.Images.SetKeyName(0, "empty-16x16.png");
			this.GCodeImages.Images.SetKeyName(1, "circle-red-16x16.png");
			// 
			// Set_mm_Btn
			// 
			this.Set_mm_Btn.Location = new System.Drawing.Point(369, 13);
			this.Set_mm_Btn.Margin = new System.Windows.Forms.Padding(4);
			this.Set_mm_Btn.Name = "Set_mm_Btn";
			this.Set_mm_Btn.Size = new System.Drawing.Size(100, 30);
			this.Set_mm_Btn.TabIndex = 53;
			this.Set_mm_Btn.Text = "Set mm";
			this.Set_mm_Btn.UseVisualStyleBackColor = true;
			this.Set_mm_Btn.Click += new System.EventHandler(this.Set_mm_Btn_Click);
			// 
			// timer
			// 
			this.timer.Interval = 250;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// Default_Btn
			// 
			this.Default_Btn.Location = new System.Drawing.Point(369, 49);
			this.Default_Btn.Margin = new System.Windows.Forms.Padding(4);
			this.Default_Btn.Name = "Default_Btn";
			this.Default_Btn.Size = new System.Drawing.Size(100, 30);
			this.Default_Btn.TabIndex = 54;
			this.Default_Btn.Text = "Set Defaults";
			this.Default_Btn.UseVisualStyleBackColor = true;
			this.Default_Btn.Click += new System.EventHandler(this.Default_Btn_Click);
			// 
			// Firmware_Btn
			// 
			this.Firmware_Btn.Location = new System.Drawing.Point(369, 84);
			this.Firmware_Btn.Margin = new System.Windows.Forms.Padding(4);
			this.Firmware_Btn.Name = "Firmware_Btn";
			this.Firmware_Btn.Size = new System.Drawing.Size(100, 30);
			this.Firmware_Btn.TabIndex = 55;
			this.Firmware_Btn.Text = "Firmware ...";
			this.Firmware_Btn.UseVisualStyleBackColor = true;
			this.Firmware_Btn.Click += new System.EventHandler(this.Firmware_Btn_Click);
			// 
			// Debug_Btn
			// 
			this.Debug_Btn.Enabled = false;
			this.Debug_Btn.Location = new System.Drawing.Point(811, 5);
			this.Debug_Btn.Name = "Debug_Btn";
			this.Debug_Btn.Size = new System.Drawing.Size(75, 25);
			this.Debug_Btn.TabIndex = 17;
			this.Debug_Btn.Text = "Debug";
			this.Debug_Btn.UseVisualStyleBackColor = true;
			this.Debug_Btn.Visible = false;
			this.Debug_Btn.Click += new System.EventHandler(this.Debug_Btn_Click);
			// 
			// mi_RunToCursor
			// 
			this.mi_RunToCursor.Name = "mi_RunToCursor";
			this.mi_RunToCursor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F10)));
			this.mi_RunToCursor.Size = new System.Drawing.Size(310, 24);
			this.mi_RunToCursor.Text = "Run to cursor";
			this.mi_RunToCursor.Click += new System.EventHandler(this.mi_RunToCursor_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1182, 600);
			this.Controls.Add(this.Debug_Btn);
			this.Controls.Add(this.Firmware_Btn);
			this.Controls.Add(this.Default_Btn);
			this.Controls.Add(this.Set_mm_Btn);
			this.Controls.Add(this.TabLogGraph);
			this.Controls.Add(this.UseResponseItems);
			this.Controls.Add(this.ClearBtn);
			this.Controls.Add(this.RefreshBtn);
			this.Controls.Add(this.ControlTabs);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.SettingsBtn);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "CNC GUI";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.speedOverrideNumber)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ControlTabs.ResumeLayout(false);
			this.PageSettings.ResumeLayout(false);
			this.PageSettings.PerformLayout();
			this.PageMotors.ResumeLayout(false);
			this.PageAxises.ResumeLayout(false);
			this.Page1.ResumeLayout(false);
			this.Page1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.MoveStep)).EndInit();
			this.Page2.ResumeLayout(false);
			this.Page2.PerformLayout();
			this.TabLogGraph.ResumeLayout(false);
			this.PageLog.ResumeLayout(false);
			this.PageGraph.ResumeLayout(false);
			this.PageGraph.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ZLevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GPlotPicture)).EndInit();
			this.PageGCode.ResumeLayout(false);
			this.GCodeMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.IO.Ports.SerialPort serialPort;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button Load_Btn;
		private System.Windows.Forms.Button StartBtn;
		private System.Windows.Forms.TextBox FileName;
		private System.Windows.Forms.Button StopBtn;
		private System.Windows.Forms.TextBox CommandLine;
		private System.Windows.Forms.Button Send_Btn;
		private System.Windows.Forms.ComboBox PortsList;
		private System.Windows.Forms.Button ReloadBtn;
		private System.Windows.Forms.Label RowsInFileLbl;
		private System.Windows.Forms.Label SentRowsLbl;
		private System.Windows.Forms.Button Stop_Btn;
		private CNCGUI.GCodeListView Log;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox overrideSpeedChkbox;
		private System.Windows.Forms.NumericUpDown speedOverrideNumber;
		private System.Windows.Forms.Button SettingsBtn;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel Status;
		private System.Windows.Forms.TabControl ControlTabs;
		private System.Windows.Forms.TabPage Page2;
		private System.Windows.Forms.TabPage Page1;
		private System.Windows.Forms.Button MoveZM;
		private System.Windows.Forms.Button MoveZP;
		private System.Windows.Forms.Button MoveYM;
		private System.Windows.Forms.Button MoveYP;
		private System.Windows.Forms.Button MoveXM;
		private System.Windows.Forms.Button MoveXP;
		private System.Windows.Forms.Button MoveHome;
		private System.Windows.Forms.Button MoveYPXP;
		private System.Windows.Forms.Button MoveYMXM;
		private System.Windows.Forms.Button MoveYPXM;
		private System.Windows.Forms.Button MoveYMXP;
		private System.Windows.Forms.TabPage PageSettings;
		private System.Windows.Forms.TextBox InfoFwBuild;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox InfoFwVersion;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox InfoHwVersion;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox InfoID;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Label label8;
		private ValueUnitControl JA;
		private ValueUnitControl CT;
		private ComboBoxEnum ST;
		private System.Windows.Forms.Label label10;
		private ComboBoxEnum EJ;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label11;
		private ComboBoxEnum JV;
		private System.Windows.Forms.CheckBox UseResponseItems;
		private System.Windows.Forms.Label label12;
		private ComboBoxEnum TV;
		private System.Windows.Forms.Label label13;
		private ComboBoxEnum QV;
		private System.Windows.Forms.Label label14;
		private ComboBoxEnum SV;
		private System.Windows.Forms.Label label15;
		private ComboBoxEnum EX;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox SI;
		private System.Windows.Forms.Label label17;
		private ComboBoxEnum IC;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private ComboBoxEnum EE;
		private ComboBoxEnum EC;
		private System.Windows.Forms.Label label20;
		private ComboBoxEnum GPL;
		private System.Windows.Forms.Label label21;
		private ComboBoxEnum GUN;
		private System.Windows.Forms.Label label24;
		private ComboBoxEnum GDI;
		private System.Windows.Forms.Label label23;
		private ComboBoxEnum GPA;
		private System.Windows.Forms.Label label22;
		private ComboBoxEnum GCO;
		private System.Windows.Forms.Label label26;
		private ComboBoxEnum BAUD;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Button RefreshBtn;
		private System.Windows.Forms.TabPage PageMotors;
		private MotorControl Motor1;
		private MotorControl Motor4;
		private MotorControl Motor3;
		private MotorControl Motor2;
		private System.Windows.Forms.TabPage PageAxises;
		private System.Windows.Forms.Button ClearBtn;
		private AxisControl AxisA;
		private AxisControl AxisZ;
		private AxisControl AxisY;
		private AxisControl AxisX;
		private System.Windows.Forms.ColumnHeader LogColumn1;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
		private System.Windows.Forms.ComboBox PortSpeed;
		private System.Windows.Forms.TabControl TabLogGraph;
		private System.Windows.Forms.TabPage PageLog;
		private System.Windows.Forms.TabPage PageGraph;
		private System.Windows.Forms.PictureBox GPlotPicture;
		private System.Windows.Forms.Button Set_mm_Btn;
		private System.Windows.Forms.CheckBox IgnoreGCodeErrors;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.NumericUpDown ZLevel;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.TextBox CurrentA;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.TextBox CurrentZ;
		private System.Windows.Forms.TextBox CurrentY;
		private System.Windows.Forms.TextBox CurrentX;
		private System.Windows.Forms.NumericUpDown MoveStep;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.TextBox CurrentA2;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.TextBox CurrentZ2;
		private System.Windows.Forms.TextBox CurrentY2;
		private System.Windows.Forms.TextBox CurrentX2;
		private System.Windows.Forms.Button Default_Btn;
		private System.Windows.Forms.Button Firmware_Btn;
		private System.Windows.Forms.TabPage PageGCode;
		private GCodeListView GCodes;
		private System.Windows.Forms.ColumnHeader columnGCode;
		private System.Windows.Forms.ColumnHeader columnBP;
		private System.Windows.Forms.ImageList GCodeImages;
		private System.Windows.Forms.ContextMenuStrip GCodeMenu;
		private System.Windows.Forms.ToolStripMenuItem mi_Run;
		private System.Windows.Forms.ToolStripMenuItem mi_Step;
		private System.Windows.Forms.ToolStripMenuItem mi_Stop;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem mi_ToggleBP;
		private System.Windows.Forms.ToolStripMenuItem mi_DeleteAllBP;
		private System.Windows.Forms.Button Debug_Btn;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem mi_NextCommand;
		private System.Windows.Forms.ToolStripMenuItem mi_RunToCursor;
	}
}