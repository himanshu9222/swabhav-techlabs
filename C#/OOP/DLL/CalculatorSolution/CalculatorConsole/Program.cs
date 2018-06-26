using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculateLibrary;

namespace CalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Calculator.Add(9, 3));
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.WriteLine(Calculator.Cube(6));
            Console.ReadKey();
        }
    }
}
