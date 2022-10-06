namespace Credit_Score_Xunit_Tests_v2
{
    public class AgeCalculatorTests
    {
        [Theory(DisplayName = "Given customer's age input, Calculate Point method returns correct Credit Point")]
        [InlineData(0, 0, 0, 5, 0)]
        [InlineData(0, 0, 0, 10, 0)]
        [InlineData(0, 0, 0, 15, 0)]
        [InlineData(0, 0, 0, 20, 3)]
        [InlineData(0, 0, 0, 25, 3)]
        [InlineData(0, 0, 0, 30, 4)]
        [InlineData(0, 0, 0, 35, 4)]
        [InlineData(0, 0, 0, 40, 5)]
        [InlineData(0, 0, 0, 45, 5)]
        [InlineData(0, 0, 0, 50, 5)]
        [InlineData(0, 0, 0, 55, 6)]
        [InlineData(0, 0, 0, 60, 6)]
        [InlineData(0, 0, 0, 65, 6)]
        [InlineData(0, 0, 0, 70, 6)]
        [InlineData(0, 0, 0, 75, 6)]
        [InlineData(0, 0, 0, 80, 6)]
        [InlineData(0, 0, 0, 85, 6)]
        [InlineData(0, 0, 0, 90, 6)]
        [InlineData(0, 0, 0, 95, 6)]
        [InlineData(0, 0, 0, 100, 6)]
        public void TestCalculatePoint__GivenCustomerAgeInput__ReturnCorrectCreditPoint(int bureauScore, int missedPaymentCount, int completedPaymentCount, int ageInYears, int expectedOutput)
        {
            var customer = new Customer(bureauScore, missedPaymentCount, completedPaymentCount, ageInYears);
            var calculator = new AgeCalculator();
            var result = calculator.Calculate(customer);
            Assert.Equal(expectedOutput, result);
        }
    }
}
