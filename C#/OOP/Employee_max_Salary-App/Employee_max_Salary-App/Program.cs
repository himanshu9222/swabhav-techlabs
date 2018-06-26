using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee_max_Salary_App
{
    class Program
    {
        static void Main(string[] args)
        {
            CSVParser x = new CSVParser(new FileLoader());
            HashSet<Employee> em = x.Parse();
            foreach (Employee e in em) 
            { 
                Console.WriteLine(e);
            }
            Console.ReadKey();
            //WebLoader wl = new WebLoader();
            //wl.LoadFile();
            //Console.ReadKey();
        }
    }
}
