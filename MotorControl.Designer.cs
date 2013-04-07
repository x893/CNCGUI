namespace CNCGUI
{
	partial class MotorControl
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
			this.MA = new CNCGUI.ComboBoxEnum();
			this.label7 = new System.Windows.Forms.Label();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.PM = new CNCGUI.ComboBoxEnum();
			this.label1 = new System.Windows.Forms.Label();
			this.PO = new CNCGUI.ComboBoxEnum();
			this.label2 = new System.Windows.Forms.Label();
			this.MI = new CNCGUI.ComboBoxEnum();
			this.label3 = new System.Windows.Forms.Label();
			this.TR = new CNCGUI.ValueUnitControl();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SA = new System.Windows.Forms.TextBox();
			this.groupBox = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// MA
			// 
			this.MA.FormattingEnabled = true;
			this.MA.Location = new System.Drawing.Point(62, 20);
			this.MA.Name = "MA";
			this.MA.Size = new System.Drawing.Size(82, 24);
			this.MA.TabIndex = 0;
			this.MA.Text = "";
			this.toolTip.SetToolTip(this.MA, "Motor Axis");
			this.MA.SelectedIndexChanged += new System.EventHandler(this.Item_Changed);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(6, 20);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 23);
			this.label7.TabIndex = 9;
			this.label7.Text = "MA";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label7, "Motor Axis");
			// 
			// PM
			// 
			this.PM.FormattingEnabled = true;
			this.PM.Location = new System.Drawing.Point(62, 200);
			this.PM.Name = "PM";
			this.PM.Size = new System.Drawing.Size(82, 24);
			this.PM.TabIndex = 5;
			this.PM.Text = "";
			this.toolTip.SetToolTip(this.PM, "Power Management");
			this.PM.SelectedIndexChanged += new System.EventHandler(this.Item_Changed);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 201);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 23);
			this.label1.TabIndex = 11;
			this.label1.Text = "PM";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label1, "Power Management");
			// 
			// PO
			// 
			this.PO.FormattingEnabled = true;
			this.PO.Location = new System.Drawing.Point(62, 170);
			this.PO.Name = "PO";
			this.PO.Size = new System.Drawing.Size(82, 24);
			this.PO.TabIndex = 4;
			this.PO.Text = "";
			this.toolTip.SetToolTip(this.PO, "Polarity");
			this.PO.SelectedIndexChanged += new System.EventHandler(this.Item_Changed);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 171);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 23);
			this.label2.TabIndex = 13;
			this.label2.Text = "PO";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label2, "Polarity");
			// 
			// MI
			// 
			this.MI.FormattingEnabled = true;
			this.MI.Location = new System.Drawing.Point(62, 140);
			this.MI.Name = "MI";
			this.MI.Size = new System.Drawing.Size(82, 24);
			this.MI.TabIndex = 3;
			this.MI.Text = "";
			this.toolTip.SetToolTip(this.MI, "Microstep");
			this.MI.SelectedIndexChanged += new System.EventHandler(this.Item_Changed);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 23);
			this.label3.TabIndex = 15;
			this.label3.Text = "MI";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label3, "Microstep");
			// 
			// TR
			// 
			this.TR.Location = new System.Drawing.Point(24, 110);
			this.TR.Name = "TR";
			this.TR.Size = new System.Drawing.Size(120, 24);
			this.TR.TabIndex = 2;
			this.toolTip.SetToolTip(this.TR, "Travel Per Revolution");
			this.TR.ValueChanged += new System.EventHandler(this.Item_Changed);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 23);
			this.label4.TabIndex = 17;
			this.label4.Text = "TR";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label4, "Travel Per Revolution");
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 50);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 23);
			this.label5.TabIndex = 18;
			this.label5.Text = "SA";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.label5, "Step Angle");
			// 
			// SA
			// 
			this.SA.Location = new System.Drawing.Point(62, 50);
			this.SA.Name = "SA";
			this.SA.Size = new System.Drawing.Size(43, 22);
			this.SA.TabIndex = 1;
			this.toolTip.SetToolTip(this.SA, "Step Angle");
			this.SA.Enter += new System.EventHandler(this.SA_Enter);
			this.SA.Leave += new System.EventHandler(this.SA_Leave);
			// 
			// groupBox
			// 
			this.groupBox.Controls.Add(this.label6);
			this.groupBox.Controls.Add(this.SA);
			this.groupBox.Controls.Add(this.label5);
			this.groupBox.Controls.Add(this.label4);
			this.groupBox.Controls.Add(this.TR);
			this.groupBox.Controls.Add(this.label3);
			this.groupBox.Controls.Add(this.MI);
			this.groupBox.Controls.Add(this.label2);
			this.groupBox.Controls.Add(this.PO);
			this.groupBox.Controls.Add(this.label1);
			this.groupBox.Controls.Add(this.PM);
			this.groupBox.Controls.Add(this.MA);
			this.groupBox.Controls.Add(this.label7);
			this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox.Location = new System.Drawing.Point(0, 0);
			this.groupBox.Name = "groupBox";
			this.groupBox.Size = new System.Drawing.Size(150, 231);
			this.groupBox.TabIndex = 10;
			this.groupBox.TabStop = false;
			this.groupBox.Text = "Caption";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(111, 50);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(33, 23);
			this.label6.TabIndex = 19;
			this.label6.Text = "deg";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MotorControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox);
			this.Name = "MotorControl";
			this.Size = new System.Drawing.Size(150, 231);
			this.groupBox.ResumeLayout(false);
			this.groupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private ComboBoxEnum MA;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.GroupBox groupBox;
		private System.Windows.Forms.Label label1;
		private ComboBoxEnum PM;
		private System.Windows.Forms.Label label2;
		private ComboBoxEnum PO;
		private System.Windows.Forms.Label label3;
		private ComboBoxEnum MI;
		private System.Windows.Forms.Label label4;
		private ValueUnitControl TR;
		private System.Windows.Forms.TextBox SA;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}
