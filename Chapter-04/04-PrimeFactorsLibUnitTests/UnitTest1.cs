using _04_PrimeFactorsLib;

namespace _04_PrimeFactorsLibUnitTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(4, "2 * 2")]
        [InlineData(14, "2 * 7")]
        [InlineData(13413, "3 * 17 * 263")]
        public void Test1(int number, string expected)
        {
            Assert.Equal(expected, CalcPrimeFactors.Calc(number));
        }
    }
}
