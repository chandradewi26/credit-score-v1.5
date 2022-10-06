namespace Credit_Score_Xunit_Tests_v2
{
    public class BureauScoreCalculatorTests
    {
        [Theory(DisplayName = "Given various Bureau Score input, Calculate Point method returns correct Credit Point")]
        [InlineData(0, 0, 0, 0, 0)]
        [InlineData(100, 0, 0, 0, 0)]
        [InlineData(150, 0, 0, 0, 0)]
        [InlineData(200, 0, 0, 0, 0)]
        [InlineData(250, 0, 0, 0, 0)]
        [InlineData(300, 0, 0, 0, 0)]
        [InlineData(350, 0, 0, 0, 0)]
        [InlineData(400, 0, 0, 0, 0)]
        [InlineData(450, 0, 0, 0, 0)]
        [InlineData(500, 0, 0, 0, 1)]
        [InlineData(550, 0, 0, 0, 1)]
        [InlineData(600, 0, 0, 0, 1)]
        [InlineData(650, 0, 0, 0, 1)]
        [InlineData(700, 0, 0, 0, 1)]
        [InlineData(750, 0, 0, 0, 2)]
        [InlineData(800, 0, 0, 0, 2)]
        [InlineData(850, 0, 0, 0, 2)]
        [InlineData(900, 0, 0, 0, 3)]
        [InlineData(950, 0, 0, 0, 3)]
        [InlineData(1000, 0, 0, 0, 3)]
        [InlineData(1050, 0, 0, 0, 0)]
        public void TestCalculatePoint__GivenBureauScoreInput__ReturnCorrectCreditPoint(int bureauScore, int missedPaymentCount, int completedPaymentCount, int ageInYears, int expectedOutput)
        {
            var customer = new Customer(bureauScore, missedPaymentCount, completedPaymentCount, ageInYears);
            var calculator = new BureauScoreCalculator();
            var result = calculator.Calculate(customer);
            Assert.Equal(expectedOutput, result);
        }
    }
}