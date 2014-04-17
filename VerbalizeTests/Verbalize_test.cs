using FluentAssertions;
using Xunit;
using Xunit.Extensions;

namespace VerbalizeTests
{
	public class Verbalize_test
	{
		public class for_ints
		{
			[Fact]
			public void Test_enviroment_is_up_and_running()
			{
				true.Should().BeTrue();
			}

			[Theory]
			[InlineData(1,"jeden")]
			[InlineData(2,"dwa")]
			[InlineData(3,"trzy")]
			[InlineData(4,"cztery")]
			[InlineData(5,"pięć")]
			[InlineData(6,"sześć")]
			[InlineData(7,"siedem")]
			[InlineData(8,"osiem")]
			[InlineData(9,"dziewięć")]
			public void One_diggit_number_is_converted_to_propper_string(int input, string expected)
			{
				input.Verbalize().Should().Be(expected);
				input.Verballize().Should().Be(expected);
			}

			[Theory]
			[InlineData(10, "dziesięć")]
			[InlineData(11, "jedenaście")]
			[InlineData(12, "dwanaście")]
			[InlineData(13, "trzynaście")]
			[InlineData(14, "czternaście")]
			[InlineData(15, "piętnaście")]
			[InlineData(16, "szesnaście")]
			[InlineData(17, "siedemnaście")]
			[InlineData(18, "osiemnaście")]
			[InlineData(19, "dziewiętnaście")]			
			public void Two_diggit_number_is_converted_to_propper_string(int input, string expected)
			{
				input.Verbalize().Should().Be(expected);
				input.Verballize().Should().Be(expected);
			}
			
			[Theory]
			[InlineData(20, "dwadzieścia")]
			[InlineData(21, "dwadzieścia jeden")]
			[InlineData(22, "dwadzieścia dwa")]
			[InlineData(23, "dwadzieścia trzy")]
			[InlineData(24, "dwadzieścia cztery")]
			[InlineData(25, "dwadzieścia pięć")]
			[InlineData(26, "dwadzieścia sześć")]
			[InlineData(27, "dwadzieścia siedem")]
			[InlineData(28, "dwadzieścia osiem")]
			[InlineData(29, "dwadzieścia dziewięć")]
			public void Two_diggit_from20_number_is_converted_to_propper_string(int input, string expected)
			{
				input.Verbalize().Should().Be(expected);
				input.Verballize().Should().Be(expected);
			}

			[Theory]
			[InlineData(30, "trzydzieści")]
			[InlineData(31, "trzydzieści jeden")]
			[InlineData(32, "trzydzieści dwa")]
			[InlineData(33, "trzydzieści trzy")]
			[InlineData(34, "trzydzieści cztery")]
			[InlineData(35, "trzydzieści pięć")]
			[InlineData(36, "trzydzieści sześć")]
			[InlineData(37, "trzydzieści siedem")]
			[InlineData(38, "trzydzieści osiem")]
			[InlineData(39, "trzydzieści dziewięć")]
			public void Two_diggit_from30_number_is_converted_to_propper_string(int input, string expected)
			{
				input.Verbalize().Should().Be(expected);
				input.Verballize().Should().Be(expected);
			}

			[Theory]
			[InlineData(40, "czterdzieści")]
			[InlineData(41, "czterdzieści jeden")]
			[InlineData(42, "czterdzieści dwa")]
			[InlineData(43, "czterdzieści trzy")]
			[InlineData(44, "czterdzieści cztery")]
			[InlineData(45, "czterdzieści pięć")]
			[InlineData(46, "czterdzieści sześć")]
			[InlineData(47, "czterdzieści siedem")]
			[InlineData(48, "czterdzieści osiem")]
			[InlineData(49, "czterdzieści dziewięć")]
			public void Two_diggit_from40_number_is_converted_to_propper_string(int input, string expected)
			{
				input.Verbalize().Should().Be(expected);
				input.Verballize().Should().Be(expected);
			}

			[Theory]
			[InlineData(50, "pięćdziesiąt")]
			[InlineData(51, "pięćdziesiąt jeden")]
			[InlineData(52, "pięćdziesiąt dwa")]
			[InlineData(53, "pięćdziesiąt trzy")]
			[InlineData(54, "pięćdziesiąt cztery")]
			[InlineData(55, "pięćdziesiąt pięć")]
			[InlineData(56, "pięćdziesiąt sześć")]
			[InlineData(57, "pięćdziesiąt siedem")]
			[InlineData(58, "pięćdziesiąt osiem")]
			[InlineData(59, "pięćdziesiąt dziewięć")]
			public void Two_diggit_from50_number_is_converted_to_propper_string(int input, string expected)
			{
				input.Verbalize().Should().Be(expected);
				input.Verballize().Should().Be(expected);
			}

			[Theory]
			[InlineData(90, "dziewięćdziesiąt")]
			[InlineData(91, "dziewięćdziesiąt jeden")]
			[InlineData(92, "dziewięćdziesiąt dwa")]
			[InlineData(93, "dziewięćdziesiąt trzy")]
			[InlineData(94, "dziewięćdziesiąt cztery")]
			[InlineData(95, "dziewięćdziesiąt pięć")]
			[InlineData(96, "dziewięćdziesiąt sześć")]
			[InlineData(97, "dziewięćdziesiąt siedem")]
			[InlineData(98, "dziewięćdziesiąt osiem")]
			[InlineData(99, "dziewięćdziesiąt dziewięć")]
			public void Two_diggit_from90_number_is_converted_to_propper_string(int input, string expected)
			{
				input.Verbalize().Should().Be(expected);
				input.Verballize().Should().Be(expected);
			}

			[Theory]
			[InlineData(100, "sto")]
			[InlineData(200, "dwieście")]
			[InlineData(300, "trzysta")]
			[InlineData(400, "czterysta")]
			[InlineData(500, "pięćset")]
			[InlineData(600, "sześćset")]
			[InlineData(700, "siedemset")]
			[InlineData(800, "osiemset")]
			[InlineData(900, "dziewięćset")]
			public void Three_diggit_hundred_number_is_converted_to_propper_string(int input, string expected)
			{
				input.Verbalize().Should().Be(expected);
				input.Verballize().Should().Be(expected);
			}


			[Theory]
			[InlineData(101, "sto jeden")]
			[InlineData(121, "sto dwadzieścia jeden")]
			[InlineData(130, "sto trzydzieści")]
			[InlineData(132, "sto trzydzieści dwa")]
			[InlineData(500, "pięćset")]
			[InlineData(501, "pięćset jeden")]
			[InlineData(502, "pięćset dwa")]
			[InlineData(503, "pięćset trzy")]
			[InlineData(511, "pięćset jedenaście")]
			[InlineData(999, "dziewięćset dziewięćdziesiąt dziewięć")]
			public void Three_diggit_numbers_is_converted_to_propper_string(int input, string expected)
			{
				input.Verbalize().Should().Be(expected);
				input.Verballize().Should().Be(expected);
			}

			[Theory]
			[InlineData(1000, "jeden tysiąc")]
			[InlineData(2000, "dwa tysiące")]
			[InlineData(3000, "trzy tysiące")]
			[InlineData(4000, "cztery tysiące")]
			[InlineData(5000, "pięć tysięcy")]
			[InlineData(6000, "sześć tysięcy")]
			[InlineData(7000, "siedem tysięcy")]
			[InlineData(8000, "osiem tysięcy")]
			[InlineData(9000, "dziewięć tysięcy")]
			[InlineData(10000, "dziesięć tysięcy")]
			[InlineData(11000, "jedenaście tysięcy")]
			[InlineData(12000, "dwanaście tysięcy")]
			[InlineData(13000, "trzynaście tysięcy")]
			public void Four_diggit_number_is_converted_to_propper_string(int input, string expected)
			{
				input.Verbalize().Should().Be(expected);
				input.Verballize().Should().Be(expected);
			}

			[Theory]
			[InlineData(1111, "jeden tysiąc sto jedenaście")]
			public void Four_diggit__number_is_converted_to_propper_string(int input, string expected)
			{
				input.Verbalize().Should().Be(expected);
				input.Verballize().Should().Be(expected);
			}
		}

	}
}