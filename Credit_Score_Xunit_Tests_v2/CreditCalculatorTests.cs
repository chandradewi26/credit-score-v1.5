using Microsoft.Extensions.DependencyInjection;

namespace Credit_Score_Xunit_Tests_v2
{
    public class CreditCalculatorTests
    {
        private readonly IServiceCollection _services;
        private readonly IServiceProvider _provider;
        private readonly ICreditCalculator _creditCalculator;

        public CreditCalculatorTests()
        {
            _services = new ServiceCollection();

            _services.AddSingleton<IBureauScoreCalculator, BureauScoreCalculator>();
            _services.AddSingleton<ICompletedPaymentCalculator, CompletedPaymentCalculator>();
            _services.AddSingleton<IMissedPaymentCalculator, MissedPaymentCalculator>();
            _services.AddSingleton<IAgeCalculator, AgeCalculator>();
            _services.AddSingleton<IPointCalculator, PointCalculator>();
            _services.AddSingleton<ICreditCalculator, CreditCalculator>();

            _provider = _services.BuildServiceProvider();

            _creditCalculator = (CreditCalculator)_provider.GetService<ICreditCalculator>(); 
        }

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
            var result = _creditCalculator.CalculateCredit(customer);
            Assert.Equal(expectedOutput, result);
        }
    }
}
