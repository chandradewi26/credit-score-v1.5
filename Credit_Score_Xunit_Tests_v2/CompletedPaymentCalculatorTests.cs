using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_Score_Xunit_Tests_v2
{
    public class CompletedPaymentCalculatorTests
    {
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
            var calculator = new CompletedPaymentCalculator();
            var result = calculator.Calculate(customer);
            Assert.Equal(expectedOutput, result);
        }
    }
}
