namespace DMHelper.Forms
{
	partial class DCCalculatorForm
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.DCCalcPercentDC_Text = new System.Windows.Forms.TextBox();
			this.DCCalcPercentLevel_Text = new System.Windows.Forms.TextBox();
			this.DCProfGoodModChance_text = new System.Windows.Forms.TextBox();
			this.DCProfNoModChance_text = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.DCNoModChance_text = new System.Windows.Forms.TextBox();
			this.DCNegModChance_text = new System.Windows.Forms.TextBox();
			this.CalculateDCPercent_Button = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(727, 471);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.CalculateDCPercent_Button);
			this.tabPage1.Controls.Add(this.DCNegModChance_text);
			this.tabPage1.Controls.Add(this.DCNoModChance_text);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.DCProfNoModChance_text);
			this.tabPage1.Controls.Add(this.DCProfGoodModChance_text);
			this.tabPage1.Controls.Add(this.DCCalcPercentLevel_Text);
			this.tabPage1.Controls.Add(this.DCCalcPercentDC_Text);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(719, 445);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "To DC";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(719, 445);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "From DC";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "DC: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Level: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(197, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Negative Mod: ";
			// 
			// DCCalcPercentDC_Text
			// 
			this.DCCalcPercentDC_Text.Location = new System.Drawing.Point(59, 27);
			this.DCCalcPercentDC_Text.Name = "DCCalcPercentDC_Text";
			this.DCCalcPercentDC_Text.Size = new System.Drawing.Size(100, 20);
			this.DCCalcPercentDC_Text.TabIndex = 3;
			// 
			// DCCalcPercentLevel_Text
			// 
			this.DCCalcPercentLevel_Text.Location = new System.Drawing.Point(59, 50);
			this.DCCalcPercentLevel_Text.Name = "DCCalcPercentLevel_Text";
			this.DCCalcPercentLevel_Text.Size = new System.Drawing.Size(100, 20);
			this.DCCalcPercentLevel_Text.TabIndex = 4;
			// 
			// DCProfGoodModChance_text
			// 
			this.DCProfGoodModChance_text.Location = new System.Drawing.Point(314, 102);
			this.DCProfGoodModChance_text.Name = "DCProfGoodModChance_text";
			this.DCProfGoodModChance_text.ReadOnly = true;
			this.DCProfGoodModChance_text.Size = new System.Drawing.Size(100, 20);
			this.DCProfGoodModChance_text.TabIndex = 5;
			// 
			// DCProfNoModChance_text
			// 
			this.DCProfNoModChance_text.Location = new System.Drawing.Point(314, 76);
			this.DCProfNoModChance_text.Name = "DCProfNoModChance_text";
			this.DCProfNoModChance_text.ReadOnly = true;
			this.DCProfNoModChance_text.Size = new System.Drawing.Size(100, 20);
			this.DCProfNoModChance_text.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(197, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Proficent Good  Mod: ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(197, 79);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Proficent No Mod: ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(197, 53);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(51, 13);
			this.label6.TabIndex = 9;
			this.label6.Text = "No Mod: ";
			// 
			// DCNoModChance_text
			// 
			this.DCNoModChance_text.Location = new System.Drawing.Point(314, 50);
			this.DCNoModChance_text.Name = "DCNoModChance_text";
			this.DCNoModChance_text.ReadOnly = true;
			this.DCNoModChance_text.Size = new System.Drawing.Size(100, 20);
			this.DCNoModChance_text.TabIndex = 10;
			// 
			// DCNegModChance_text
			// 
			this.DCNegModChance_text.Location = new System.Drawing.Point(314, 24);
			this.DCNegModChance_text.Name = "DCNegModChance_text";
			this.DCNegModChance_text.ReadOnly = true;
			this.DCNegModChance_text.Size = new System.Drawing.Size(100, 20);
			this.DCNegModChance_text.TabIndex = 11;
			// 
			// CalculateDCPercent_Button
			// 
			this.CalculateDCPercent_Button.Location = new System.Drawing.Point(84, 104);
			this.CalculateDCPercent_Button.Name = "CalculateDCPercent_Button";
			this.CalculateDCPercent_Button.Size = new System.Drawing.Size(75, 23);
			this.CalculateDCPercent_Button.TabIndex = 12;
			this.CalculateDCPercent_Button.Text = "Calculate";
			this.CalculateDCPercent_Button.UseVisualStyleBackColor = true;
			this.CalculateDCPercent_Button.Click += new System.EventHandler(this.CalculateDCPercent_Button_Click);
			// 
			// DCCalculatorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(751, 495);
			this.Controls.Add(this.tabControl1);
			this.MaximizeBox = false;
			this.Name = "DCCalculatorForm";
			this.Text = "DCCalculatorForm";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TextBox DCProfNoModChance_text;
		private System.Windows.Forms.TextBox DCProfGoodModChance_text;
		private System.Windows.Forms.TextBox DCCalcPercentLevel_Text;
		private System.Windows.Forms.TextBox DCCalcPercentDC_Text;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button CalculateDCPercent_Button;
		private System.Windows.Forms.TextBox DCNegModChance_text;
		private System.Windows.Forms.TextBox DCNoModChance_text;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
	}
}