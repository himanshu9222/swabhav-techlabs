using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceCRUD_App
{
    class CustomerDB : Icrudable
    {
     
	public void create() {
		Console.WriteLine("Customer created.");

	}

	public void read() {
        Console.WriteLine("Customer Read.");

	}

	public void update() {
        Console.WriteLine("Customer Update.");

	}

	public void delete() {
        Console.WriteLine("Customer Delete.");

	}
    }
}
