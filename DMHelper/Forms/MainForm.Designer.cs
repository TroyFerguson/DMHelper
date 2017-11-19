namespace DMHelper
{
	partial class MainForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dCCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aCCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(682, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// windowToolStripMenuItem
			// 
			this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mathToolStripMenuItem});
			this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
			this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
			this.windowToolStripMenuItem.Text = "Window";
			// 
			// mathToolStripMenuItem
			// 
			this.mathToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dCCalculatorToolStripMenuItem,
            this.aCCalculatorToolStripMenuItem});
			this.mathToolStripMenuItem.Name = "mathToolStripMenuItem";
			this.mathToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.mathToolStripMenuItem.Text = "Math";
			// 
			// dCCalculatorToolStripMenuItem
			// 
			this.dCCalculatorToolStripMenuItem.Name = "dCCalculatorToolStripMenuItem";
			this.dCCalculatorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.dCCalculatorToolStripMenuItem.Text = "DC Calculator";
			this.dCCalculatorToolStripMenuItem.Click += new System.EventHandler(this.DCCalculatorToolStripMenuItem_Click);
			// 
			// aCCalculatorToolStripMenuItem
			// 
			this.aCCalculatorToolStripMenuItem.Name = "aCCalculatorToolStripMenuItem";
			this.aCCalculatorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.aCCalculatorToolStripMenuItem.Text = "AC Calculator";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 333);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(682, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(682, 355);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "DMHelper";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mathToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dCCalculatorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aCCalculatorToolStripMenuItem;
	}
}

