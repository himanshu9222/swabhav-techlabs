using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateLib
{
    public class Calculator
    {
        public double CubeIsEven(double number)
        {
            if (number%2 !=0)
            {
                throw new Exception("Not Even Number");
            }
            else
            return number * number * number;
            
        }
    }
}
