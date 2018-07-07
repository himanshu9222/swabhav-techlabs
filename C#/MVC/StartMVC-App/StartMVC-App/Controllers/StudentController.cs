using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StartMVC_App.Models;

namespace StartMVC_App.Controllers
{
    public class StudentController : Controller
    {

        public ActionResult GetStudent()
        {
            GetStudentViewModel vm = new GetStudentViewModel();
            vm.Students = new List<Student> { new Student {Name = "Himanshu",RollNo = 12 },
                                                new Student {Name = "Prasad", RollNo = 11 } };
            vm.Address = new List<string> {"Mumbai", "Pune" };

            return View(vm);
        }
    }
}