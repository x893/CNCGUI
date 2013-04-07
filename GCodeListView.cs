using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace CNCGUI
{
	public class GCodeListView : ListView
	{
		[Browsable(false)]
		public int SavedLine { get; set; }
		[Browsable(false)]
		public int CurrentLine { get; set; }
		[Browsable(false)]
		public int StopLine { get; set; }

		public GCodeListView()
		{
			// Enable internal ListView double-buffering
			SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
		}
	}
}
