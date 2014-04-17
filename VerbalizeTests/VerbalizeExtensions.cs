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
			"dzwiewięćdziesiąt",
		};


		public static string Verballize(this int value)
		{
			return value.Verbalize();
		}

		public static string Verbalize(this int value)
		{
			if(value <= 19) return ZeroNineghteen[value];

			if (value <= 99)
			{
				var mod = value%10;
				var rest = value/10;

				if (mod == 0)
				{
					return Tens[rest-1];
				} else
				{
					return Tens[rest - 1] + " " + ZeroNineghteen[mod];
				}
			}

			return string.Empty;
		}
	}



}
