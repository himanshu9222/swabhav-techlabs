using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyConsoleApp
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string Dept_Name { get; set; }
        public List<Employee> EmployeeList { get; set; }

        public Department()
        {
            EmployeeList = new List<Employee>();
        }
    }
}
