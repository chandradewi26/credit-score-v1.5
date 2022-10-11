namespace Credit_Score_App
{
    public class CreditCalculator : ICreditCalculator
    {
        private readonly IPointCalculator _pointCalculator;

        //Get the point calculator using dependency-injection
        public CreditCalculator(IPointCalculator pointCalculator)
        {
            _pointCalculator = pointCalculator;
        }
        public decimal CalculateCredit (Customer customer)
        {
            int point = _pointCalculator.Calculate(customer);

            //Check if declined
            if (customer.BureauScore <= 450 || point <= 0)
            {
                Console.Write("Declined");
                return 0M;
            }

            //Calculate credit
            if ( point >= 1 && point <= 6 )
            {
                return point * 100M;
            }
            else if ( point > 6 )
            {
                return 600M;
            }

            return 0M;
        }
    }
}
