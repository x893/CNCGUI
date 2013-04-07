using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace CNCGUI
{
	public class GCodeListViewItem : ListViewItem
	{
		private bool m_bp = false;
		[DefaultValue(false)]
		[Browsable(false)]
		public bool Breakpoint
		{
			get { return m_bp; }
			set { m_bp = value; }
		}
	}
}
