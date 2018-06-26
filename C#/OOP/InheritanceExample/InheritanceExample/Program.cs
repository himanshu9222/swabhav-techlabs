using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Manager(100, "Himanshu", 1000);
            Employee e2 = new Developer(200, "him", 1000);

            printDetails(e1);
            printDetails(e2);

            //case1();
            //case2();
            //case3();
            //case4();
            Console.ReadKey();
        }


        public static void printDetails(Employee e)
        {
            Console.WriteLine("EmployeeId = " + e.EmployeeNo + "\nName = " + e.Name + "\n Salary = " + e.calNetSalary() + "");
        }
        public static void case1()
        {
            Man x;
            x = new Man();
            x.eat();
            x.play();
            x.read();
        }

        public static void case2()
        {
            Boy y;
            y = new Boy();
            y.eat();
            y.read();
            y.walk();
            y.play();
        }

        public static void case3()
        {
            Man x;
            x = new Boy();
            x.eat();
            x.read();
            x.play();
        }

        public static void case4()
        {
            atThePark(new Man());
            atThePark(new Boy());
            atThePark(new Kid());
            atThePark(new Infant());
        }

        public static void atThePark(Man x)
        {
            Console.WriteLine("At the Park");
            x.play();
        }
    }
}
