using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInjection_App
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator tc = new TaxCalculator(new Csv());
            Console.WriteLine(tc.calculate(1000, 0));
            Console.ReadKey();
        }
    }
}
