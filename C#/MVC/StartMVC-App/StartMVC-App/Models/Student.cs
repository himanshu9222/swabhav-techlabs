using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartMVC_App.Models
{
    public class Student
    {
        private string _name;
        private int _rollno;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int RollNo
        {
            get { return _rollno; }
            set { _rollno = value; }
        }
    }
}