using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMHelper.DND
{
	struct DCSuccessRange
	{
		public double NegMod;
		public double NoMod;
		public double ProficentNoMod;
		public double ProficentGoodMod;
	}

	class Dice
	{
		public const uint DICE_PER = 100;
		public const uint DICE_D20 = 20;
		public const uint DICE_D12 = 12;
		public const uint DICE_D10 = 10;
		public const uint DICE_D8 = 8;
		public const uint DICE_D6 = 6;
		public const uint DICE_D4 = 4;
	}
}
