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
    public void TestCalculatePoint_GivenBureauScoreInput(int bureauScore, int missedPaymentCount, int completedPaymentCount, int ageInYears, int expectedOutput)
    {
        var customer = new Customer(bureauScore, missedPaymentCount, completedPaymentCount, ageInYears);
        var calculator = new CreditCalculator();
        var result = calculator.CalculateBureauScore(customer);
        Assert.Equal(expectedOutput, result);
    }

    [Theory(DisplayName = "Given Missed Payment Count input, Calculate Point method returns correct Credit Point")]
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
        var calculator = new CreditCalculator();
        var result = calculator.CalculateMissedPaymentCount(customer);
        Assert.Equal(expectedOutput, result);
    }


    [Theory(DisplayName = "Given Completed Payment Count input, Calculate Point method returns correct Credit Point")]
    [InlineData(0, 0, 0, 0, 0)]
    [InlineData(0, 0, 1, 0, 2)]
    [InlineData(0, 0, 2, 0, 3)]
    [InlineData(0, 0, 3, 0, 4)]
    [InlineData(0, 0, 4, 0, 4)]
    [InlineData(0, 0, 5, 0, 4)]
    [InlineData(0, 0, 6, 0, 4)]
    [InlineData(0, 0, 7, 0, 4)]
    [InlineData(0, 0, 8, 0, 4)]
    [InlineData(0, 0, 9, 0, 4)]
    [InlineData(0, 0, 10, 0, 4)]
    public void GivenCompletedPaymentCountInput(int bureauScore, int missedPaymentCount, int completedPaymentCount, int ageInYears, int expectedOutput)
    {
        var customer = new Customer(bureauScore, missedPaymentCount, completedPaymentCount, ageInYears);
        var calculator = new CreditCalculator();
        var result = calculator.CalculateCompletedPaymentCount(customer);
        Assert.Equal(expectedOutput, result);
    }



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
    public void GivenCustomerAgeInput(int bureauScore, int missedPaymentCount, int completedPaymentCount, int ageInYears, int expectedOutput)
    {
        var customer = new Customer(bureauScore, missedPaymentCount, completedPaymentCount, ageInYears);
        var calculator = new CreditCalculator();
        var result = calculator.CalculateAge(customer);
        Assert.Equal(expectedOutput, result);
    }

    [Theory(DisplayName = "Given customer's input, Calculate Point method returns correct Credit Point")]
    [InlineData(100, 0, 3, 30, 8)]
    [InlineData(1200, 1, 3, 60, 9)]
    [InlineData(500, 1, 0, 20, 3)]
    [InlineData(500, 1, 3, 20, 7)]
    [InlineData(500, 5, 1, 30, 1)]
    [InlineData(750, 1, 3, 29, 9)]
    [InlineData(750, 2, 3, 30, 7)]
    [InlineData(800, 0, 1, 30, 8)]
    [InlineData(900, 0, 1, 55, 11)]
    [InlineData(900, 1, 2, 20, 8)]
    [InlineData(900, 2, 1, 30, 6)]
    [InlineData(900, 3, 3, 40, 6)]
    [InlineData(950, 0, 2, 15, 6)]
    public void TestCalculatePoint_GivenCustomerInput(int bureauScore, int missedPaymentCount, int completedPaymentCount, int ageInYears, int expectedOutput)
    {
        var customer = new Customer(bureauScore, missedPaymentCount, completedPaymentCount, ageInYears);
        var calculator = new CreditCalculator();
        var result = calculator.CalculatePoint(customer);
        Assert.Equal(expectedOutput, result);
    }
}