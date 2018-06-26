using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateLibrary
{
    public class Calculator
    {
        public static int Add(int number1, int number2)
        {
            if (number1 < 0 | number2 < 0)
            {
                throw new NegativeNumberException();
            }
            else
            return number1 + number2;
        }

        public static int Cube(int number)
        {
            if (number % 2 == 0)
                return number * number * number;
            else
                return 0;
        }
    }
}
