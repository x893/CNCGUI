namespace CNCGUI
{
	partial class ValueUnitControl
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
			this.TextValue = new System.Windows.Forms.TextBox();
			this.UnitValue = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// TextValue
			// 
			this.TextValue.Location = new System.Drawing.Point(0, 1);
			this.TextValue.Name = "TextValue";
			this.TextValue.Size = new System.Drawing.Size(64, 22);
			this.TextValue.TabIndex = 0;
			this.TextValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// UnitValue
			// 
			this.UnitValue.FormattingEnabled = true;
			this.UnitValue.Items.AddRange(new object[] {
            "mm",
            "in"});
			this.UnitValue.Location = new System.Drawing.Point(70, 0);
			this.UnitValue.Name = "UnitValue";
			this.UnitValue.Size = new System.Drawing.Size(50, 24);
			this.UnitValue.TabIndex = 1;
			// 
			// ValueUnitControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.UnitValue);
			this.Controls.Add(this.TextValue);
			this.Name = "ValueUnitControl";
			this.Size = new System.Drawing.Size(120, 24);
			this.Enter += new System.EventHandler(this.ValueUnitControl_Enter);
			this.Leave += new System.EventHandler(this.ValueUnitControl_Leave);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TextValue;
		private System.Windows.Forms.ComboBox UnitValue;
	}
}
