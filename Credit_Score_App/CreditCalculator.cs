namespace Credit_Score_App
{
    public class CreditCalculator : ICreditCalculator
    {
        private readonly ICalculator _pointCalculator;

        public CreditCalculator(ICalculator pointCalculator)
        {
            _pointCalculator = pointCalculator;
        }
        public decimal CalculateCredit (Customer customer)
        {
            //This is dependency, we need to inject this from constructor
            //PointCalculator pointCalculator = new PointCalculator();
            
            //Get the points
            //int point = pointCalculator.Calculate(customer);
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
