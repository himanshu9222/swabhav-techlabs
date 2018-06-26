using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosed_App
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fixedDeposit = new FixedDeposit(123, "Himanshu", 10000, 3,
				new NewYear());
		Console.WriteLine(fixedDeposit.calculateTotalInterest());
        Console.ReadKey();
        }
    }
}
