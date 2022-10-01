namespace Credit_Score_App
{
    public class MissedPaymentCalculator : ICalculator
    {
        public int Calculate(Customer customer)
        {
            int point = 0;

            switch (customer.MissedPaymentCount)
            {
                case 0:
                    point += 0;
                    break;
                case 1:
                    point += -1;
                    break;
                case 2:
                    point += -3;
                    break;
                case >= 3:
                    point += -6;
                    break;
                default:
                    point += 0;
                    break;
            }

            return point;
        }
    }
}
