namespace Credit_Score_App
{
    public class BureauScoreCalculator : ICalculator
    {
        public int Calculate(Customer customer)
        {
            int point = 0;

            //Bureau Score
            if (customer.BureauScore > 450 && customer.BureauScore <= 700)
            {
                point += 1;
            }
            else if (customer.BureauScore > 700 && customer.BureauScore <= 850)
            {
                point += 2;
            }
            else if (customer.BureauScore > 850 && customer.BureauScore <= 1000)
            {
                point += 3;
            }
            else //Lower than 450 or Higher than 1000
            {
                point += 0;
            }

            return point;
        }
    }
}
