namespace Credit_Score_Xunit_Tests_v2
{
    public class MissedPaymentCalculatorTests
    {
        [Theory(DisplayName = "Given Missed Payment Count input, Calculate Point method returns correct Credit Point")]
        [InlineData(0, -5, 0, 0, 0)]
        [InlineData(0, 0, 0, 0, 0)]
        [InlineData(0, 1, 0, 0, -1)]
        [InlineData(0, 2, 0, 0, -3)]
        [InlineData(0, 3, 0, 0, -6)]
        [InlineData(0, 4, 0, 0, -6)]
        [InlineData(0, 5, 0, 0, -6)]
        [InlineData(0, 6, 0, 0, -6)]
        [InlineData(0, 7, 0, 0, -6)]
        [InlineData(0, 8, 0, 0, -6)]
        [InlineData(0, 9, 0, 0, -6)]
        [InlineData(0, 10, 0, 0, -6)]
        public void TestCalculatePoint_GivenMissedPaymentCountInput(int bureauScore, int missedPaymentCount, int completedPaymentCount, int ageInYears, int expectedOutput)
        {
            var customer = new Customer(bureauScore, missedPaymentCount, completedPaymentCount, ageInYears);
            var calculator = new MissedPaymentCalculator();
            var result = calculator.Calculate(customer);
            Assert.Equal(expectedOutput, result);
        }
    }
}
