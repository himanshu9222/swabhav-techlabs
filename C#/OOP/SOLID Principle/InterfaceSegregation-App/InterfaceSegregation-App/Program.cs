using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceSegregation_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            Robot r = new Robot();
            atTheWorkStaion(m);
            atTheWorkStaion(r);

            atTheCafeteria(m);
            //atTheCafeteria(r);
            Console.ReadKey();

        }

        public static void atTheWorkStaion(IWorkable obj){
		Console.WriteLine("At the Work Station");
		obj.StartWorking();
		obj.StopWorking();
	}

        public static void atTheCafeteria(IEatable obj){
		Console.WriteLine("At the Cafeteria");
		obj.StartEating();
		obj.StopEating();
	}
    }
}
