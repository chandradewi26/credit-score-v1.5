namespace Credit_Score_App
{
    public class AgeCalculator : ICalculator
    {
        public int Calculate(Customer customer)
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
    }
}