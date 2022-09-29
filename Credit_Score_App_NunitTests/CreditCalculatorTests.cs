using Credit_Score_App;

namespace Credit_Score_App_NunitTests
{
    [TestFixture]   //Not entirely sure why
    public class CreditCalculatorTests
    {
        //Arrange
        private CreditCalculator _creditCalculator;
        [SetUp]
        public void Setup()
        {
            _creditCalculator = new CreditCalculator();
        }


        [Test]
        //[Ignore("Ignore test under constructions")]
        public void CalculatePoint_PassCustomer_ShouldReturnCorrectPoints()
        {
            //Arrange - Given customers
            Customer customer_pass1 = new Customer(999, 0, 3, 40); // 3    0   4   5   =   12  ($600)

            //Act
            int points = _creditCalculator.CalculatePoint(customer_pass1);

            //Assert
            Assert.AreEqual(12, points, "Should return 12");
        }



        [TestCase(0, 0, 3, 52, 0)]          //customer_decline 0    0   4   6   =   10  ($0)
        [TestCase(451, 3, 0, 20, 0)]        //customer_fail    1    -6  0   3   =   -2  ($0)
        [TestCase(451, 2, 0, 20, 100)]      //customer_pass2   1    -3  0   3   =   1   ($100)
        public void CalculateCredit_PassCustomer_ShouldReturn(int bureauScore, int missedPaymentCount, int completedPaymentCount, int ageInYears, decimal expectedCredit)
        {
            //Argument Expection : Way 1
            if (bureauScore < 0 || missedPaymentCount < 0 || completedPaymentCount < 0 || ageInYears < 0 || expectedCredit < 0)
            {
                throw new ArgumentException(
                    "Please input positive numbers!");
            }

            //Arrange - Given customers
            Customer _customer = new Customer(bureauScore, missedPaymentCount, completedPaymentCount, ageInYears);
            //Act
            decimal credit = _creditCalculator.CalculateCredit(_customer);
            //Assert
            Assert.AreEqual(expectedCredit, credit, "Should return expected credit");
        }

        [TearDown]
        public void TearDown()
        {
            _creditCalculator = null;
        }



    }
}