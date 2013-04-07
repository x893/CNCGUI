using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CNCGUI
{
	public class ListViewEx : ListView
	{
		public ListViewEx()
		{
			// Enable internal ListView double-buffering
			SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
		}
	}
}
