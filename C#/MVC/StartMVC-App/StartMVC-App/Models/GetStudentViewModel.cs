using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartMVC_App.Models
{
    public class GetStudentViewModel
    {
        List<Student> students;
        List<string> address;

        public GetStudentViewModel()
        {
            students = new List<Student>();
            address = new List<string>();
        }

        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }

        public List<string> Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}