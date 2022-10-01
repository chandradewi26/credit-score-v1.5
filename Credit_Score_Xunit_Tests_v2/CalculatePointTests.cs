using Credit_Score_App;

namespace Credit_Score_Xunit_Tests_v2;

public class CalculatePointTests
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
    [InlineData(500, 0, 0, 0, 0)]
    [InlineData(550, 0, 0, 0, 0)]
    [InlineData(600, 0, 0, 0, 0)]
    [InlineData(650, 0, 0, 0, 0)]
    [InlineData(700, 0, 0, 0, 0)]
    [InlineData(750, 0, 0, 0, 0)]
    [InlineData(800, 0, 0, 0, 0)]
    [InlineData(850, 0, 0, 0, 0)]
    [InlineData(900, 0, 0, 0, 0)]
    [InlineData(950, 0, 0, 0, 0)]
    [InlineData(1000, 0, 0, 0, 0)]
    public void TestCalculatePoint_GivenBureauScoreInput(int bureauScore, int missedPaymentCount, int completedPaymentCount, int ageInYears, int expectedOutput)
    {
        var customer = new Customer(bureauScore, missedPaymentCount, completedPaymentCount, ageInYears);
        var calculator = new CreditCalculator();
        var result = calculator.CalculatePoint(customer);
        Assert.Equal(expectedOutput, result);
    }

    [Theory(DisplayName = "Given Missed Payment Count input, Calculate Point method returns correct Credit Point")]
    [InlineData(0, 0, 0, 0, 0)]
    [InlineData(0, 1, 0, 0, 0)]
    [InlineData(0, 2, 0, 0, 0)]
    [InlineData(0, 3, 0, 0, 0)]
    [InlineData(0, 4, 0, 0, 0)]
    [InlineData(0, 5, 0, 0, 0)]
    [InlineData(0, 6, 0, 0, 0)]
    [InlineData(0, 7, 0, 0, 0)]
    [InlineData(0, 8, 0, 0, 0)]
    [InlineData(0, 9, 0, 0, 0)]
    [InlineData(0, 10, 0, 0, 0)]
    public void TestCalculatePoint_GivenMissedPaymentCountInput(int bureauScore, int missedPaymentCount, int completedPaymentCount, int ageInYears, int expectedOutput)
    {
        var customer = new Customer(bureauScore, missedPaymentCount, completedPaymentCount, ageInYears);
        var calculator = new CreditCalculator();
        var result = calculator.CalculatePoint(customer);
        Assert.Equal(expectedOutput, result);
    }


    [Theory(DisplayName = "Given Completed Payment Count input, Calculate Point method returns correct Credit Point")]
    [InlineData(0, 0, 0, 0, 0)]
    [InlineData(0, 0, 1, 0, 0)]
    [InlineData(0, 0, 2, 0, 0)]
    [InlineData(0, 0, 3, 0, 0)]
    [InlineData(0, 0, 4, 0, 0)]
    [InlineData(0, 0, 5, 0, 0)]
    [InlineData(0, 0, 6, 0, 0)]
    [InlineData(0, 0, 7, 0, 0)]
    [InlineData(0, 0, 8, 0, 0)]
    [InlineData(0, 0, 9, 0, 0)]
    [InlineData(0, 0, 10, 0, 0)]
    public void GivenCompletedPaymentCountInput(int bureauScore, int missedPaymentCount, int completedPaymentCount, int ageInYears, int expectedOutput)
    {
        var customer = new Customer(bureauScore, missedPaymentCount, completedPaymentCount, ageInYears);
        var calculator = new CreditCalculator();
        var result = calculator.CalculatePoint(customer);
        Assert.Equal(expectedOutput, result);
    }



    [Theory(DisplayName = "Given customer's age input, Calculate Point method returns correct Credit Point")]
    [InlineData(0, 0, 0, 5, 0)]
    [InlineData(0, 0, 0, 10, 0)]
    [InlineData(0, 0, 0, 15, 0)]
    [InlineData(0, 0, 0, 20, 0)]
    [InlineData(0, 0, 0, 25, 0)]
    [InlineData(0, 0, 0, 30, 0)]
    [InlineData(0, 0, 0, 35, 0)]
    [InlineData(0, 0, 0, 40, 0)]
    [InlineData(0, 0, 0, 45, 0)]
    [InlineData(0, 0, 0, 50, 0)]
    [InlineData(0, 0, 0, 55, 0)]
    [InlineData(0, 0, 0, 60, 0)]
    [InlineData(0, 0, 0, 65, 0)]
    [InlineData(0, 0, 0, 70, 0)]
    [InlineData(0, 0, 0, 75, 0)]
    [InlineData(0, 0, 0, 80, 0)]
    [InlineData(0, 0, 0, 85, 0)]
    [InlineData(0, 0, 0, 90, 0)]
    [InlineData(0, 0, 0, 95, 0)]
    [InlineData(0, 0, 0, 100, 0)]
    public void GivenCustomerAgeInput(int bureauScore, int missedPaymentCount, int completedPaymentCount, int ageInYears, int expectedOutput)
    {
        var customer = new Customer(bureauScore, missedPaymentCount, completedPaymentCount, ageInYears);
        var calculator = new CreditCalculator();
        var result = calculator.CalculatePoint(customer);
        Assert.Equal(expectedOutput, result);
    }
}