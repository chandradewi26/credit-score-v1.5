using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_Score_App
{
    public class PointCalculator : ICalculator
    {
        public int Calculate(Customer customer)
        {
            int point = 0;

            ICalculator bureauScoreCalculator = new BureauScoreCalculator();
            ICalculator completedPaymentCalculator = new CompletedPaymentCalculator();
            ICalculator missedPaymentCalculator = new MissedPaymentCalculator();
            ICalculator ageCalculator = new AgeCalculator();

            point += bureauScoreCalculator.Calculate(customer);
            point += completedPaymentCalculator.Calculate(customer);
            point += missedPaymentCalculator.Calculate(customer);
            point += ageCalculator.Calculate(customer);

            return point;
        }
    }
}
