using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithCollection_App
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeList = new List<Employee>();
            employeeList.Add(new Employee(7698, "BLAKE", "MANAGER", 7839, "1-MAY-81", 2850, 0, 30));
            employeeList.Add(new Employee(7369, "SMITH", "CLERK", 7902, "17-DEC-80", 800, 200, 20));
            employeeList.Add(new Employee(7934, "MILLER", "CLERK", 7782, "23-JAN-82", 1300, 300, 10));
            employeeList.Add(new Employee(7788, "SCOTT", "ANALYST", 7566, "09-DEC-82", 3000, 50, 20));
            employeeList.Add(new Employee(7654, "MARTIN", "SALESMAN", 7698, "28-SEP-84", 1250, 1400, 30));

            var displayByName = from e in employeeList
                                orderby e.Name
                                select new { e.Id, e.Name };

            foreach (var employee in displayByName)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine();


            var displayBySalaryDesc = from e in employeeList
                                      orderby e.Salary descending
                                      select new { e.Id, e.Name, e.Salary };

            foreach (var employee in displayBySalaryDesc)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine();


            var displayMaxSalaryEarningEmployee = employeeList.First(e => e.Salary == employeeList.Max(m => m.Salary));
            Console.WriteLine(displayMaxSalaryEarningEmployee + "\n");

            var displayAllManagers = employeeList.Where(e => e.Role == "MANAGER");
            employeeList.Add(new Employee(7782, "CLARK", "MANAGER", 7839, "9-JUN-81", 2450, 1500, 10));
            foreach (var employee in displayAllManagers)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine();

            var displayTop2SalaryEmployee = employeeList.OrderByDescending(x => x.Salary).ToArray().Take(2);
            foreach (var employee in displayTop2SalaryEmployee)
            {
                Console.WriteLine(employee);
            }

            Console.ReadKey();
        }
    }
}

