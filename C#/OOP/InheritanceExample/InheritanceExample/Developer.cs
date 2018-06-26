using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceExample
{
    class Developer : Employee
    {
        private double perks;
	private double sal;
	public Developer(int e, String n, double b) :
		base(e, n, b){
	}

	
	public override double calNetSalary() {
		perks=basic*0.3;
		sal=basic+perks;
		return sal;
	}
    }
}
