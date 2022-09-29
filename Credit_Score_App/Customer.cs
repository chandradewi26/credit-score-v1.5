using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_Score_App
{
    public class Customer
    {
        //Coding Convention for private 
        private string _customerName;
        public int BureauScore { get; }
        public int MissedPaymentCount { get; }
        public int CompletedPaymentCount { get; }
        public int AgeInYears { get; }
        public Customer(int bureauScore, int missedPaymentCount, int completedPaymentCount, int ageInYears)
        {
            BureauScore = bureauScore;
            MissedPaymentCount = missedPaymentCount;
            CompletedPaymentCount = completedPaymentCount;
            AgeInYears = ageInYears;
        }

        //Coding convention for String Interpolation
        public void DisplayName()
        {
            Console.WriteLine($"Customer name is : {_customerName}");
        }
    }
}
