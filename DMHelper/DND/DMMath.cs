using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMHelper.DND
{
	class DMMath
	{
		public static int GetProficencyBonus(int Level)
		{
			decimal ProficencyStep = Math.Ceiling((decimal)(Level/4.0));
			return 1 + (int)(ProficencyStep);
		}

		public static double ChanceToBeat(uint DieSize, uint DieRoll)
		{
			double PercentPerSide = 100.0 / (double)DieSize;
			double Chance = (DieSize - DieRoll - 1) * PercentPerSide;

			return Math.Min(Math.Max(Chance, 0.0), 100.0);
		}

		public static DCSuccessRange GetDCSuccessChance(uint DC, int Level)
		{
			uint DCDiceSize = DMHelper.DND.Dice.DICE_D20;

			DCSuccessRange SuccessRange = new DCSuccessRange();

			SuccessRange.NegMod = ChanceToBeat(DCDiceSize, (uint)(DC - Properties.Settings.Default.NegativeModValue));
			SuccessRange.NoMod = ChanceToBeat(DCDiceSize, DC);
			SuccessRange.ProficentNoMod = ChanceToBeat(DCDiceSize, (uint)(DC - GetProficencyBonus(Level)));
			SuccessRange.ProficentGoodMod = ChanceToBeat(DCDiceSize, (uint)(DC - (GetProficencyBonus(Level) + Properties.Settings.Default.GoodModValue)));

			return SuccessRange;
		}
	}
}
