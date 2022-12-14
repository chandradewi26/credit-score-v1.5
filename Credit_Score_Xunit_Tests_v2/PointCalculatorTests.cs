using Microsoft.Extensions.DependencyInjection;

namespace Credit_Score_Xunit_Tests_v2;

public class PointCalculatorTests
{
    private readonly IServiceCollection _services;
    private readonly IServiceProvider _provider;
    private readonly IPointCalculator _pointCalculator;

    public PointCalculatorTests()
    {
        _services = new ServiceCollection();

        _services.AddSingleton<IBureauScoreCalculator, BureauScoreCalculator>();
        _services.AddSingleton<ICompletedPaymentCalculator, CompletedPaymentCalculator>();
        _services.AddSingleton<IMissedPaymentCalculator, MissedPaymentCalculator>();
        _services.AddSingleton<IAgeCalculator, AgeCalculator>();
        _services.AddSingleton<IPointCalculator, PointCalculator>();

        _provider = _services.BuildServiceProvider();

        _pointCalculator = (PointCalculator)_provider.GetService<IPointCalculator>();
    }

    [Theory(DisplayName = "Given customer's input, Calculate Point method returns correct Credit Point")]
    [InlineData(100, 0, 3, 30, 8)]
    [InlineData(1200, 1, 3, 60, 9)] //Realized that I was getting confused between characterization test and actually doing the test. The original result was 9
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
        var result = _pointCalculator.Calculate(customer);
        Assert.Equal(expectedOutput, result);
    }
}