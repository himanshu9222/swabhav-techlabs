using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceCRUD_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Icrudable x;
            x = new CustomerDB();
            x.create();

            x = new DeptDB();
            x.create();

            doDBOperation(new CustomerDB());
            doDBOperation(new EmploeeDB());
            doDBOperation(new DeptDB());
            Console.ReadKey();
        }

	public static void doDBOperation(Icrudable x) {
		Console.WriteLine("\nIn DoDBOperation Method.");
		x.create();
		x.read();
		x.update();
		x.delete();
	}
    }
}
