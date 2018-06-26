using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceExample
{
    class Manager : Employee
    {
        private double hra;
        private double ta;
        private double sal;

        public Manager(int e, String n, double b)
            : base(e, n, b)
        {
        }


        public override double calNetSalary()
        {
            hra = basic * 0.5;
            ta = basic * 0.4;
            sal = basic + hra + ta;
            return sal;
        }
    }
}
