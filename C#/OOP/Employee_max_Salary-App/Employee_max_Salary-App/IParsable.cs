using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee_max_Salary_App
{
    interface IParsable
    {
        HashSet<Employee> Parse();
    }
}
