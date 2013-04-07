using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace CNCGUI
{
	public partial class AxisControl : UserControl
	{
		public event EventHandler ValueChanged;

		private Axis m_axis;
		private string m_caption;
		private bool ignore_changes = true;
		private string vm_saved, fm_saved, jh_saved, jd_saved, sv_saved, lv_saved, lb_saved, zb_saved, tm_saved;
		private string jm_saved, ra_saved;

		[Browsable(false)]
		public Axis Axis
		{
			get { return m_axis; }
			set
			{
				m_axis = value;
				Redraw();
			}
		}

		[DefaultValue(null)]
		public string Caption
		{
			get { return m_caption; }
			set { m_caption = value; }
		}

		protected override void OnLoad(EventArgs e)
		{
			groupBox.Text = m_caption;
			base.OnLoad(e);
		}

		public void Redraw()
		{
			ignore_changes = true;

			if (m_caption == "A")
			{
				RA.Visible = true;
				label14.Visible = true;
			}
			else
			{
				RA.Visible = false;
				label14.Visible = false;
			}

			if (m_axis != null)
			{
				AM.Set(m_axis.AxisMode);
				VM.Text = m_axis.Velocity.ToString(CultureInfo.InvariantCulture.NumberFormat);
				FR.Text = m_axis.Feedrate.ToString(CultureInfo.InvariantCulture.NumberFormat);
				JH.Text = m_axis.JerkHoming.ToString(CultureInfo.InvariantCulture.NumberFormat);
				JD.Text = m_axis.JunctionDeviation.ToString(CultureInfo.InvariantCulture.NumberFormat);
				SN.Set(m_axis.SwitchMin);
				SX.Set(m_axis.SwitchMax);
				SV.Text = m_axis.SearchVelocity.ToString(CultureInfo.InvariantCulture.NumberFormat);
				LV.Text = m_axis.LatchVelocity.ToString(CultureInfo.InvariantCulture.NumberFormat);
				LB.Text = m_axis.LatchBackoff.ToString(CultureInfo.InvariantCulture.NumberFormat);
				ZB.Text = m_axis.ZeroBackoff.ToString(CultureInfo.InvariantCulture.NumberFormat);
				TM.Text = m_axis.TravelMaximum.ToString(CultureInfo.InvariantCulture.NumberFormat);
				JM.Text = m_axis.JerkMaximum.ToString(CultureInfo.InvariantCulture.NumberFormat);
				RA.Text = m_axis.Radius.ToString(CultureInfo.InvariantCulture.NumberFormat);

				ignore_changes = false;
			}
			else
			{
				AM.Items.Clear();
				SN.Items.Clear();
				SX.Items.Clear();
				VM.Text = "";
				FR.Text = "";
				JD.Text = "";
				SV.Text = "";
				LV.Text = "";
				LB.Text = "";
				ZB.Text = "";
				TM.Text = "";
				JM.Text = "";
				RA.Text = "";
			}
		}

		public AxisControl()
		{
			InitializeComponent();
		}

		private void Item_Changed(object sender, EventArgs e)
		{
			if (!ignore_changes)
			{
				if (ValueChanged != null)
					ValueChanged(this, EventArgs.Empty);
			}
		}

		private void SA_Enter(object sender, EventArgs e)
		{
			vm_saved = VM.Text;
			fm_saved = FR.Text;
			jh_saved = JH.Text;
			jd_saved = JD.Text;
			sv_saved = SV.Text;
			lv_saved = LV.Text;
			lb_saved = LB.Text;
			zb_saved = ZB.Text;
			tm_saved = TM.Text;
			jm_saved = JM.Text;
			ra_saved = RA.Text;
		}

		private void SA_Leave(object sender, EventArgs e)
		{
			if (!ignore_changes &&
				(
				vm_saved != VM.Text
			|| fm_saved != FR.Text
			|| jh_saved != JH.Text
			|| jd_saved != JD.Text
			|| sv_saved != SV.Text
			|| lv_saved != LV.Text
			|| lb_saved != LB.Text
			|| zb_saved != ZB.Text
			|| tm_saved != TM.Text
			|| jm_saved != JM.Text
			|| ra_saved != RA.Text
				))
			{
				if (ValueChanged != null)
					ValueChanged(this, EventArgs.Empty);
			}
		}
	}
}
