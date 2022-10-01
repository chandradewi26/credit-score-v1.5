using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_Score_App
{
    public interface ICalculator
    {
        int Calculate(Customer customer);
    }
}
