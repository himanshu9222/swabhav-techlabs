using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceExample
{
    abstract class Employee
    {
        private int empno;
        private String name;
        protected double basic;

        public Employee(int e, String n, double b)
        {
            empno = e;
            name = n;
            basic = b;
        }

        public abstract double calNetSalary();


        public int EmployeeNo
        {
            get { return empno; }
        }

        public String Name
        {
            get { return name;}
        }

        public double Basic
        {
            get{return basic;}
        }
    }
}
