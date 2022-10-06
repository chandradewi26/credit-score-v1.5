namespace Credit_Score_App
{
    public class BureauScoreCalculator : ICalculator
    {
        public int Calculate(Customer customer)
        {
            var bureauScore = customer.BureauScore;
            if (bureauScore > 450 && bureauScore <= 700)
                return 1;
            if (bureauScore > 700 && bureauScore <= 850)
                return 2;
            if (bureauScore > 850 && bureauScore <= 1000)
                return 3; 
        return 0;
        }
    }
}
