using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceCRUD_App
{
    class DeptDB : Icrudable
    {
      
	public void create() {
        Console.WriteLine("DeptDB created.");

	}


	public void read() {
        Console.WriteLine("DeptDB Read.");

	}


	public void update() {
        Console.WriteLine("DeptDB update.");

	}

	public void delete() {
        Console.WriteLine("DeptDB Deleted.");

	}
    }
}
