using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee_max_Salary_App
{
    class Employee
    {
        private int _id;
        private String _name;
        private String _role;
        private int _managerId;
        private String _dateOfJoining;
        private double _salary;
        private double _commission;
        private int _deptId;

        public Employee(int id, String name, String role, int managerId,
                String dateOfJoining, double salary, double commission, int deptid)
        {
            this._id = id;
            this._name = name;
            this._role = role;
            this._managerId = managerId;
            this._dateOfJoining = dateOfJoining;
            this._salary = salary;
            this._commission = commission;
            this._deptId = deptid;
        }

        public int Id { get { return _id; } set { _id = value; } }

        public string Name { get { return _name; } set { _name = value; } }

        public string Role { get { return _role; } set { _role = value; } }

        public int ManagerId { get { return _managerId; } set { _managerId = value; } }

        public string DateOfJoining { get { return _dateOfJoining; } set { _dateOfJoining = value; } }

        public double Salary { get { return _salary; } set { _salary = value; } }

        public double Commission { get { return _commission; } set { _commission = value; } }

        public int DeptId { get { return _deptId; } set { _deptId = value; } }

        public override bool Equals(Object obj)
        {
            Employee emp = (Employee)obj;
            return this.Id == emp.Id;
        }
        
        public override int GetHashCode()
        {
            return this.Id;
        }

        public override string ToString()
        {
            return " "+_id+" "+_name+" "+_role+" "+_managerId+" "+_dateOfJoining+" "+_salary+" "+_commission+" "+_deptId+"";
        }
    }
}
