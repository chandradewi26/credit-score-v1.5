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
            int point = 0;
            switch (customer.CompletedPaymentCount)
            {
                case 0:
                    point += 0;
                    break;
                case 1:
                    point += 2;
                    break;
                case 2:
                    point += 3;
                    break;
                case >= 3:
                    point += 4;
                    break;
                default:
                    point += 0;
                    break;
            }
            return point;
        }
    }
}
