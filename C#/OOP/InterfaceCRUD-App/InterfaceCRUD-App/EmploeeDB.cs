using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceCRUD_App
{
    class EmploeeDB : Icrudable
    {
        
	public void create() {
        Console.WriteLine("Employee created.");

	}

	
	public void read() {
        Console.WriteLine("Employee Read.");

	}

	
	public void update() {
        Console.WriteLine("Employee Update.");

	}

	
	public void delete() {
        Console.WriteLine("Employee Deleted.");

	}
    }
}
