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
	public partial class MotorControl : UserControl
	{
		public event EventHandler ValueChanged;

		private Motor m_motor;
		private string m_caption;
		private bool ignore_changes = true;
		private string text_saved;

		[Browsable(false)]
		public Motor Motor
		{
			get { return m_motor; }
			set
			{
				m_motor = value;
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
			if (m_motor != null)
			{
				MA.Set(m_motor.Axis);
				PM.Set(m_motor.PowerManagement);
				PO.Set(m_motor.Polarity);
				MI.Set(m_motor.Microstep);
				TR.Set(m_motor.TravelPerRevolution);
				SA.Text = m_motor.StepAngle.ToString(CultureInfo.InvariantCulture.NumberFormat);
				ignore_changes = false;
			}
			else
			{
				MA.Items.Clear();
				PM.Items.Clear();
				PO.Items.Clear();
				MI.Items.Clear();
				TR.Clear();
				SA.Text = "";
			}
		}

		public MotorControl()
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
			text_saved = SA.Text;
		}

		private void SA_Leave(object sender, EventArgs e)
		{
			if (!ignore_changes &&
				(text_saved != SA.Text)
				)
			{
				if (ValueChanged != null)
					ValueChanged(this, EventArgs.Empty);
			}
		}
	}
}
