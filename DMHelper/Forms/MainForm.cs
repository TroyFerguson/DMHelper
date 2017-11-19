using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DMHelper.Forms;

namespace DMHelper
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void DCCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DMHelper.Forms.DCCalculatorForm NewDCCalulatorForm = new DMHelper.Forms.DCCalculatorForm("DCCalc");
			NewDCCalulatorForm.MdiParent = this;
			NewDCCalulatorForm.Show();
		}
	}
}
