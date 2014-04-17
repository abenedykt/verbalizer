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

		}

	}
}