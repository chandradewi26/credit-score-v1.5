namespace Credit_Score_Xunit_Tests_v2
{
    public class CreditCalculatorTests
    {
        [Theory(DisplayName = "Given customer's input, Calculate Credit method returns correct credit")]
        [InlineData(100, 0, 3, 30, 0)]
        [InlineData(1200, 1, 3, 60, 600)]
        [InlineData(500, 1, 0, 20, 300)]
        [InlineData(500, 1, 3, 20, 600)]
        [InlineData(500, 5, 1, 30, 100)]
        [InlineData(750, 1, 3, 29, 600)]
        [InlineData(750, 2, 3, 30, 600)]
        [InlineData(800, 0, 1, 30, 600)]
        [InlineData(900, 0, 1, 55, 600)]
        [InlineData(900, 1, 2, 20, 600)]
        [InlineData(900, 2, 1, 30, 600)]
        [InlineData(900, 3, 3, 40, 600)]
        [InlineData(950, 0, 2, 15, 600)]
        public void TestCalculateCredit_GivenCustomerInput(int bureauScore, int missedPaymentCount, int completedPaymentCount, int ageInYears, int expectedOutput)
        {
            var customer = new Customer(bureauScore, missedPaymentCount, completedPaymentCount, ageInYears);
            var calculator = new CreditCalculator();
            var result = calculator.CalculateCredit(customer);
            Assert.Equal(expectedOutput, result);
        }
    }
}
