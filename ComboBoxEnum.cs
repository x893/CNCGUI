using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CNCGUI
{
	public partial class ComboBoxEnum : ComboBox
	{
		public event EventHandler ValueChanged;

		private bool ignore_changes = true;
		private string m_text = null;

		public ComboBoxEnum()
		{
			InitializeComponent();
		}

		[DefaultValue(null)]
		public override string Text
		{
			get
			{
				return m_text;
			}
			set
			{
				m_text = value;
				base.Text = m_text;
			}
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
		}

		internal void Set(Type type, Enum value)
		{
			ignore_changes = true;
			int idx = -1, sel = -1;

			Items.Clear();

			foreach (Enum x in Enum.GetValues(type))
			{
				idx++;
				Items.Add(x.ToString());
				if (x.Equals(value))
					sel = idx;
			}
			if (sel >= 0)
				this.SelectedIndex = sel;
			ignore_changes = false;
		}

		internal void Set(EnumValue enumValue)
		{
			ignore_changes = true;
			Items.Clear();

			if (enumValue.Items == null || enumValue.Items.Count == 0)
			{
				if (enumValue.EnumType != null)
				{
					if (enumValue.Items == null)
						enumValue.Items = new Dictionary<int,string>();
					else
						enumValue.Items.Clear();

					foreach (Enum x in Enum.GetValues(enumValue.EnumType))
					{
						int value = (int)Convert.ChangeType(x, typeof(int));
						if(!enumValue.Items.ContainsKey(value))
							enumValue.Items.Add(value, x.ToString());
					}
				}
			}

			if (enumValue.Items != null && enumValue.Items.Count > 0)
			{
				int idx = -1;
				foreach (KeyValuePair<int,string> pair in enumValue.Items)
				{
					idx++;
					ComboBoxEnumItem li = new ComboBoxEnumItem(pair.Value, pair.Key);
					Items.Add(li);
					if (enumValue.ValueInt == pair.Key)
						SelectedIndex = idx;
				}
			}
			ignore_changes = false;
		}

		public class ComboBoxEnumItem
		{
			public string Text;
			public int Value;
			public ComboBoxEnumItem(string text, int value)
			{
				Text = text;
				Value = value;
			}
			public override string ToString()
			{
				return Text;
			}
		}

		private void ComboBoxEnum_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!ignore_changes && ValueChanged!=null)
			{
				ValueChanged(this, EventArgs.Empty);
			}
		}
	}
}
