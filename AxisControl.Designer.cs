namespace CNCGUI
{
	partial class AxisControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label7 = new System.Windows.Forms.Label();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.VM = new System.Windows.Forms.TextBox();
			this.FR = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.JH = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.JD = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SV = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox = new System.Windows.Forms.GroupBox();
			this.LV = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.LB = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.ZB = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.TM = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.JM = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.RA = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.SX = new CNCGUI.ComboBoxEnum();
			this.SN = new CNCGUI.ComboBoxEnum();
			this.AM = new CNCGUI.ComboBoxEnum();
			this.groupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(6, 20);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 23);
			this.label7.TabIndex = 9;
			this.label7.Text = "AM";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label7, "Axis Mode");
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 23);
			this.label5.TabIndex = 18;
			this.label5.Text = "VM";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label5, "Velocity Maximum (mm/min)");
			// 
			// VM
			// 
			this.VM.Location = new System.Drawing.Point(47, 47);
			this.VM.Name = "VM";
			this.VM.Size = new System.Drawing.Size(97, 22);
			this.VM.TabIndex = 1;
			this.VM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.toolTip.SetToolTip(this.VM, "Velocity Maximum (mm/min)");
			this.VM.Enter += new System.EventHandler(this.SA_Enter);
			this.VM.Leave += new System.EventHandler(this.SA_Leave);
			// 
			// FR
			// 
			this.FR.Location = new System.Drawing.Point(47, 72);
			this.FR.Name = "FR";
			this.FR.Size = new System.Drawing.Size(97, 22);
			this.FR.TabIndex = 2;
			this.FR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.toolTip.SetToolTip(this.FR, "FeedRate Maximum (mm/min)");
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(6, 72);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 23);
			this.label8.TabIndex = 21;
			this.label8.Text = "FR";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label8, "FeedRate Maximum (mm/min)");
			// 
			// JH
			// 
			this.JH.Location = new System.Drawing.Point(47, 97);
			this.JH.Name = "JH";
			this.JH.Size = new System.Drawing.Size(97, 22);
			this.JH.TabIndex = 3;
			this.JH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.toolTip.SetToolTip(this.JH, "Jerk Homing");
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 97);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 23);
			this.label1.TabIndex = 23;
			this.label1.Text = "JH";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label1, "Jerk Homing");
			// 
			// JD
			// 
			this.JD.Location = new System.Drawing.Point(47, 121);
			this.JD.Name = "JD";
			this.JD.Size = new System.Drawing.Size(97, 22);
			this.JD.TabIndex = 4;
			this.JD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.toolTip.SetToolTip(this.JD, "Junction Deviation");
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 23);
			this.label2.TabIndex = 25;
			this.label2.Text = "JD";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label2, "Junction Deviation");
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 146);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 23);
			this.label3.TabIndex = 26;
			this.label3.Text = "SN";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label3, "Switch Minimum");
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 173);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 23);
			this.label4.TabIndex = 28;
			this.label4.Text = "SX";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label4, "Switch Maximum");
			// 
			// SV
			// 
			this.SV.Location = new System.Drawing.Point(47, 200);
			this.SV.Name = "SV";
			this.SV.Size = new System.Drawing.Size(97, 22);
			this.SV.TabIndex = 7;
			this.SV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.toolTip.SetToolTip(this.SV, "Search Velocity");
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 200);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 23);
			this.label6.TabIndex = 30;
			this.label6.Text = "SV";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label6, "Search Velocity");
			// 
			// groupBox
			// 
			this.groupBox.Controls.Add(this.label14);
			this.groupBox.Controls.Add(this.RA);
			this.groupBox.Controls.Add(this.label13);
			this.groupBox.Controls.Add(this.JM);
			this.groupBox.Controls.Add(this.label12);
			this.groupBox.Controls.Add(this.TM);
			this.groupBox.Controls.Add(this.label11);
			this.groupBox.Controls.Add(this.ZB);
			this.groupBox.Controls.Add(this.label10);
			this.groupBox.Controls.Add(this.LB);
			this.groupBox.Controls.Add(this.label9);
			this.groupBox.Controls.Add(this.LV);
			this.groupBox.Controls.Add(this.label6);
			this.groupBox.Controls.Add(this.SV);
			this.groupBox.Controls.Add(this.label4);
			this.groupBox.Controls.Add(this.SX);
			this.groupBox.Controls.Add(this.label3);
			this.groupBox.Controls.Add(this.label2);
			this.groupBox.Controls.Add(this.JD);
			this.groupBox.Controls.Add(this.label1);
			this.groupBox.Controls.Add(this.JH);
			this.groupBox.Controls.Add(this.label8);
			this.groupBox.Controls.Add(this.FR);
			this.groupBox.Controls.Add(this.VM);
			this.groupBox.Controls.Add(this.label5);
			this.groupBox.Controls.Add(this.SN);
			this.groupBox.Controls.Add(this.AM);
			this.groupBox.Controls.Add(this.label7);
			this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox.Location = new System.Drawing.Point(0, 0);
			this.groupBox.Name = "groupBox";
			this.groupBox.Size = new System.Drawing.Size(150, 380);
			this.groupBox.TabIndex = 10;
			this.groupBox.TabStop = false;
			this.groupBox.Text = "Caption";
			// 
			// LV
			// 
			this.LV.Location = new System.Drawing.Point(47, 225);
			this.LV.Name = "LV";
			this.LV.Size = new System.Drawing.Size(97, 22);
			this.LV.TabIndex = 8;
			this.LV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.toolTip.SetToolTip(this.LV, "Latch Velocity");
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(6, 225);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(35, 23);
			this.label9.TabIndex = 32;
			this.label9.Text = "LV";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label9, "Latch Velocity");
			// 
			// LB
			// 
			this.LB.Location = new System.Drawing.Point(47, 250);
			this.LB.Name = "LB";
			this.LB.Size = new System.Drawing.Size(97, 22);
			this.LB.TabIndex = 9;
			this.LB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.toolTip.SetToolTip(this.LB, "Latch Backoff");
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(6, 250);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(35, 23);
			this.label10.TabIndex = 34;
			this.label10.Text = "LB";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label10, "Latch Backoff");
			// 
			// ZB
			// 
			this.ZB.Location = new System.Drawing.Point(47, 275);
			this.ZB.Name = "ZB";
			this.ZB.Size = new System.Drawing.Size(97, 22);
			this.ZB.TabIndex = 10;
			this.ZB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.toolTip.SetToolTip(this.ZB, "Zero Backoff");
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(6, 275);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(35, 23);
			this.label11.TabIndex = 36;
			this.label11.Text = "ZB";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label11, "Zero Backoff");
			// 
			// TM
			// 
			this.TM.Location = new System.Drawing.Point(47, 300);
			this.TM.Name = "TM";
			this.TM.Size = new System.Drawing.Size(97, 22);
			this.TM.TabIndex = 11;
			this.TM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.toolTip.SetToolTip(this.TM, "Travel Maximum");
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(6, 300);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(35, 23);
			this.label12.TabIndex = 38;
			this.label12.Text = "TM";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label12, "Travel Maximum");
			// 
			// JM
			// 
			this.JM.Location = new System.Drawing.Point(47, 325);
			this.JM.Name = "JM";
			this.JM.Size = new System.Drawing.Size(97, 22);
			this.JM.TabIndex = 12;
			this.JM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.toolTip.SetToolTip(this.JM, "Jerk Maximum (deg/min^3)");
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(6, 325);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(35, 23);
			this.label13.TabIndex = 40;
			this.label13.Text = "JM";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label13, "Jerk Maximum (deg/min^3)");
			// 
			// RA
			// 
			this.RA.Location = new System.Drawing.Point(47, 351);
			this.RA.Name = "RA";
			this.RA.Size = new System.Drawing.Size(97, 22);
			this.RA.TabIndex = 13;
			this.RA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.toolTip.SetToolTip(this.RA, "Radius (mm)");
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(6, 351);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(35, 23);
			this.label14.TabIndex = 42;
			this.label14.Text = "RA";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label14, "Radius (mm)");
			// 
			// SX
			// 
			this.SX.FormattingEnabled = true;
			this.SX.Location = new System.Drawing.Point(47, 173);
			this.SX.Name = "SX";
			this.SX.Size = new System.Drawing.Size(97, 24);
			this.SX.TabIndex = 6;
			this.SX.Text = "";
			this.toolTip.SetToolTip(this.SX, "Switch Maximum");
			this.SX.SelectedIndexChanged += new System.EventHandler(this.Item_Changed);
			// 
			// SN
			// 
			this.SN.FormattingEnabled = true;
			this.SN.Location = new System.Drawing.Point(47, 146);
			this.SN.Name = "SN";
			this.SN.Size = new System.Drawing.Size(97, 24);
			this.SN.TabIndex = 5;
			this.SN.Text = "";
			this.toolTip.SetToolTip(this.SN, "Switch Minimum");
			this.SN.SelectedIndexChanged += new System.EventHandler(this.Item_Changed);
			// 
			// AM
			// 
			this.AM.FormattingEnabled = true;
			this.AM.Location = new System.Drawing.Point(47, 20);
			this.AM.Name = "AM";
			this.AM.Size = new System.Drawing.Size(97, 24);
			this.AM.TabIndex = 0;
			this.AM.Text = "";
			this.toolTip.SetToolTip(this.AM, "Axis Mode");
			this.AM.SelectedIndexChanged += new System.EventHandler(this.Item_Changed);
			// 
			// AxisControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox);
			this.Name = "AxisControl";
			this.Size = new System.Drawing.Size(150, 380);
			this.groupBox.ResumeLayout(false);
			this.groupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private ComboBoxEnum AM;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.GroupBox groupBox;
		private ComboBoxEnum SN;
		private System.Windows.Forms.TextBox VM;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox FR;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox JH;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox JD;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private ComboBoxEnum SX;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox SV;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox LV;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox LB;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox ZB;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox TM;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox JM;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox RA;
	}
}
