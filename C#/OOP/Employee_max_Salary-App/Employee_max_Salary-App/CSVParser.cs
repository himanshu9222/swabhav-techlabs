using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee_max_Salary_App
{
    class CSVParser : IParsable
    {
        private HashSet<Employee> employeeList = new HashSet<Employee>();
        //Employee employee;
        ILoadable load;
        public CSVParser(ILoadable load)
        {
            this.load = load;
        }

        public HashSet<Employee> Parse()
        {
            int ID = 0, NAME = 1, ROLE = 2, MANAGERID = 3, DOJ = 4, SALARY = 5, COMMISSION = 6, DEPTID = 7;
            string finalContent = load.LoadFile();
            //System.out.println(finalContent);
            char[] sp = { '/' };
            string[] content = finalContent.Split(sp);
            char[] spp = { ',' };
            for (int i = 0; i < content.Length-1; i++)
            {
                String[] information = content[i].Split(spp);
                if (information[3].Equals("NULL"))
                {
                    information[3] = "0";
                }
                if (information[6].Equals("NULL"))
                {
                    information[6] = "0";
                }
                employeeList.Add(new Employee(int.Parse(information[ID]),
                    information[NAME], information[ROLE], int.Parse(information[MANAGERID]),
                    information[DOJ], double.Parse(information[SALARY]),
                    double.Parse(information[COMMISSION]), int.Parse(information[DEPTID])));
            }
            return employeeList;
        }
    }
}
