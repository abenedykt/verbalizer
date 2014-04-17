using System.ComponentModel;

namespace VerbalizeTests
{
	public static class VerbalizeExtensions
	{
		private static readonly string[] ZeroNineghteen =
		{
			"zero",
			"jeden",
			"dwa",
			"trzy",
			"cztery",
			"pięć",
			"sześć",
			"siedem",
			"osiem",
			"dziewięć",
			"dziesięć",
			"jedenaście",
			"dwanaście",
			"trzynaście",
			"czternaście",
			"piętnaście",
			"szesnaście",
			"siedemnaście",
			"osiemnaście",
			"dziewiętnaście"
		};

		private static readonly string[] Tens =
		{
			"dziesięć",
			"dwadzieścia",
			"trzydzieści",
			"czterdzieści",
			"pięćdziesiąt",
			"sześćdziesiąt",
			"siedemdziesiąt",
			"osiemdziesiąt",
			"dziewięćdziesiąt"
		};

		private static readonly string[] Hundreds =
		{
			"zero",
			"sto",
			"dwieście",
			"trzysta",
			"czterysta",
			"pięćset",
			"sześćset",
			"siedemset",
			"osiemset",
			"dziewięćset"
		};


		public static string Verballize(this int value)
		{
			return value.Verbalize();
		}

		public static string Verbalize(this int value)
		{
			if (value <= 19) return ZeroNineghteen[value];

			if (value <= 99)
			{
				var mod = value % 10;
				var rest = value / 10;

				if (mod == 0)
				{
					return Tens[rest - 1];
				}
				else
				{
					return Tens[rest - 1] + " " + ZeroNineghteen[mod];
				}
			}

			var hundredMod = value / 100;
			var hundredRest = value % 100;

			if (value <= 999)
			{
				if (hundredRest != 0)
				{
					return Hundreds[hundredMod] + " " + (value - (hundredMod * 100)).Verbalize();
				}
				return Hundreds[hundredMod];
			}


			var thousandMod = value / 1000;
			var thousandRest = value % 1000;
			if (thousandRest != 0)
			{
				return thousandMod.Verbalize() + " " + thousandMod.Thousends() + " " + (value - (thousandMod*1000)).Verbalize();
			}
			return thousandMod.Verbalize() + " " + thousandMod.Thousends();
		}

		private static string Thousends(this int value)
		{
			switch (value)
			{
				case 1: 
					return "tysiąc";
				case 2: 
					return "tysiące";
				case 3: 
					return "tysiące";
				case 4: 
					return "tysiące";
				default: 
					return "tysięcy";
			}
		}
	}



}
