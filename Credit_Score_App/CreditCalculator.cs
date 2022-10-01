namespace Credit_Score_App
{
    interface ICreditCalculator
    {
        decimal CalculateCredit(Customer customer);
    }

    public class CreditCalculator : ICreditCalculator
    {
        public int CalculatePoint (Customer customer)
        {
            ICalculator bureauScoreCalculator = new BureauScoreCalculator();
            ICalculator completedPaymentCalculator = new CompletedPaymentCalculator();
            ICalculator missedPaymentCalculator = new MissedPaymentCalculator();
            ICalculator ageCalculator = new AgeCalculator();

            int point = 0;

            point += bureauScoreCalculator.Calculate(customer);
            point += completedPaymentCalculator.Calculate(customer);
            point += missedPaymentCalculator.Calculate(customer);
            point += ageCalculator.Calculate(customer);

            return point;
        }

        public decimal CalculateCredit (Customer customer)
        {
            //Get the points
            int point = CalculatePoint(customer);

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
