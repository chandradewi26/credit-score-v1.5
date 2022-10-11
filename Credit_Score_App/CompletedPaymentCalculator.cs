using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_Score_App
{
    public class CompletedPaymentCalculator : ICalculator
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
