namespace Credit_Score_App
{
    public interface IMissedPaymentCalculator : ICalculator
    {
        
    }
    public class MissedPaymentCalculator : IMissedPaymentCalculator
    {
        public int Calculate(Customer customer)
        {
            var missedPayment = customer.MissedPaymentCount;
            if (missedPayment == 0)
                return 0;
            if (missedPayment == 1)
                return -1;
            if (missedPayment == 2)
                return -3;
            if (missedPayment >= 3)
                return -6;
            return 0;   
        }
    }
}
