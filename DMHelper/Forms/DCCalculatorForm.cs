using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMHelper.Forms
{
	public partial class DCCalculatorForm : Form
	{
		public DCCalculatorForm(String Title)
		{
			InitializeComponent();
			Text = Title;
		}

		private void CalculateDCPercent_Button_Click(object sender, EventArgs e)
		{
			uint DC = Convert.ToUInt16(DCCalcPercentDC_Text.Text);
			int Level = Convert.ToInt16(DCCalcPercentLevel_Text.Text);
			DMHelper.DND.DCSuccessRange SuccessRange = DMHelper.DND.DMMath.GetDCSuccessChance(DC, Level);

			DCNegModChance_text.Text = SuccessRange.NegMod.ToString();
			DCNoModChance_text.Text = SuccessRange.NoMod.ToString();
			DCProfNoModChance_text.Text = SuccessRange.ProficentNoMod.ToString();
			DCProfGoodModChance_text.Text = SuccessRange.ProficentGoodMod.ToString();
		}
	}
}
