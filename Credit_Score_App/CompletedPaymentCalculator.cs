namespace Credit_Score_App
{
    public interface ICompletedPaymentCalculator : ICalculator
    {
    }
    
    public class CompletedPaymentCalculator : ICompletedPaymentCalculator
    {
        public int Calculate(Customer customer)
        {
            var completedPayment = customer.CompletedPaymentCount;
            if (completedPayment == 0)
                return 0;
            if (completedPayment == 1)
                return 2;
            if (completedPayment == 2)
                return 3;
            if (completedPayment >= 3)
                return 4;
            return 0;    
        }
    }
}
