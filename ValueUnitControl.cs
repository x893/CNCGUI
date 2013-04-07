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
	public partial class ValueUnitControl : UserControl
	{
		public event EventHandler ValueChanged;
		private bool ignore_changes = true;
		private string text_saved;
		private int item_saved;

		public ValueUnitControl()
		{
			InitializeComponent();
		}

		public void Set(FloatUnit value)
		{
			ignore_changes = true;
			TextValue.Text = value.Value.ToString(CultureInfo.InvariantCulture);
			if (value.Unit == UNIT.mm)
				UnitValue.SelectedIndex = 0;
			else
				UnitValue.SelectedIndex = 1;
			ignore_changes = false;
		}
		public void Set(IntegerUnit value)
		{
			ignore_changes = true;
			TextValue.Text = value.Value.ToString(CultureInfo.InvariantCulture);
			if (value.Unit == UNIT.mm)
				UnitValue.SelectedIndex = 0;
			else
				UnitValue.SelectedIndex = 1;
			ignore_changes = false;
		}
		public void Clear()
		{
			ignore_changes = true;
			TextValue.Text = "";
			UnitValue.SelectedIndex = 0;
			ignore_changes = false;

		}

		private void ValueUnitControl_Enter(object sender, EventArgs e)
		{
			text_saved = TextValue.Text;
			item_saved = UnitValue.SelectedIndex;
		}

		private void ValueUnitControl_Leave(object sender, EventArgs e)
		{
			if (!ignore_changes &&
				(text_saved != TextValue.Text || item_saved != UnitValue.SelectedIndex)
				)
			{
				if (ValueChanged != null)
					ValueChanged(this, EventArgs.Empty);
			}
		}
	}
}
