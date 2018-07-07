using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleLoginMvc.Models;

namespace SampleLoginMvc.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Login()
        {
            LoginViewModel vm = new LoginViewModel();
            
            return View(vm);
        }

       [HttpPost]
       public ActionResult Login(LoginViewModel vm)
        {
            vm.Message = "Enter Proper Name and Password";
            if (vm.UserName == "root" && vm.Password == "root")
            {               
                vm.Message = "Login Successful";
                vm.LoginState = true;
            }
            
            return View(vm);
        }
    }
}