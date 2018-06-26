using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Player_App
{
    class Program
    {
        static void Main(string[] args)
        {
            caseStudy1();

        }

        private static void caseStudy1() {
		Player sachin = new Player(10, "Sachin", 45);
		Player virat = new Player(10, "Sachin");

		Console.WriteLine(sachin.Equals(virat));
		Console.WriteLine(sachin == virat);

		Player elder = sachin.whoIsElder(virat);
		Console.WriteLine(sachin.Age);
		Console.WriteLine(virat.Age);
		
		Console.WriteLine(elder.Name);

        Console.WriteLine("Object is "+sachin);
        Console.ReadKey();
	}
    }
}
