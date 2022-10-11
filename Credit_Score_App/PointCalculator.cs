namespace Credit_Score_App
{
    public interface IPointCalculator : ICalculator
    {
    }

    public class PointCalculator : IPointCalculator
    {
        private readonly IBureauScoreCalculator _bureauScoreCalculator;
        private readonly ICompletedPaymentCalculator _completedPaymentCalculator;
        private readonly IMissedPaymentCalculator _missedPaymentCalculator;
        private readonly IAgeCalculator _ageCalculator;

        //Get all the necessary calculators using dependency-injection
        public PointCalculator(
            IBureauScoreCalculator bureauScoreCalculator, 
            ICompletedPaymentCalculator completedPaymentCalculator, 
            IMissedPaymentCalculator missedPaymentCalculator, 
            IAgeCalculator ageCalculator)
        {
            _bureauScoreCalculator = bureauScoreCalculator;
            _completedPaymentCalculator = completedPaymentCalculator;
            _missedPaymentCalculator = missedPaymentCalculator;
            _ageCalculator = ageCalculator;
        }
        
        public int Calculate(Customer customer)
        {
            int point = 0;

            point += _bureauScoreCalculator.Calculate(customer);
            point += _completedPaymentCalculator.Calculate(customer);
            point += _missedPaymentCalculator.Calculate(customer);
            point += _ageCalculator.Calculate(customer);

            return point;
        }
    }
}
