using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_Score_App
{
    interface ICreditCalculator
    {
        decimal CalculateCredit(Customer customer);
    }

    public class CreditCalculator : ICreditCalculator
    {
        public int CalculateAge (Customer customer)
        {
            int point = 0;
            if (customer.AgeInYears >= 18 && customer.AgeInYears <= 25)
            {
                point += 3;
            }
            else if (customer.AgeInYears >= 26 && customer.AgeInYears <= 35)
            {
                point += 4;
            }
            else if (customer.AgeInYears >= 36 && customer.AgeInYears <= 50)
            {
                point += 5;
            }
            else if (customer.AgeInYears >= 51)
            {
                point += 6;
            }
            else
            {
                point += 0;
            }
            return point;

        }
        public int CalculateBureauScore (Customer customer)
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

        public int CalculateMissedPaymentCount (Customer customer)
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

        public int CalculateCompletedPaymentCount (Customer customer)
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

        public int CalculatePoint (Customer customer)
        {
            int point = 0;

            point += CalculateBureauScore(customer);
            point += CalculateCompletedPaymentCount(customer);
            point += CalculateMissedPaymentCount(customer);
            point += CalculateAge(customer);

            return point;
        }

        public decimal CalculateCredit (Customer customer)
        {
            //Get the points
            int point = CalculatePoint(customer);

            //Check if declined
            if (customer.BureauScore <= 450 || point <= 0)
            {
                Console.Write("Declined");
                return 0M;
            }

            //Calculate credit
            if ( point >= 1 && point <= 6 )
            {
                return point * 100M;
            }
            else if ( point > 6 )
            {
                return 600M;
            }

            return 0M;
        }
    }
}
