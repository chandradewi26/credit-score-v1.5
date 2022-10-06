namespace Credit_Score_App
{
    public class CreditCalculator : ICreditCalculator
    {
        public decimal CalculateCredit (Customer customer)
        {
            PointCalculator pointCalculator = new PointCalculator();
            //Get the points
            int point = pointCalculator.Calculate(customer);

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
