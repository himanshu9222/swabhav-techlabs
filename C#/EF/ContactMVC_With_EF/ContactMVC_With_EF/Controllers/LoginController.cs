using ContactMVC_With_EF.Services;
using ContactMVC_With_EF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactMVC_With_EF.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult LoginUser()
        {
            LoginViewModel vm = new LoginViewModel();
            return View(vm);
        }

        [HttpPost]
        public ActionResult LoginUser(LoginViewModel vm)
        {
            LoginService ls = new LoginService();
            vm.Message = "Enter Proper Name and Password";
            if (ModelState.IsValid)
            {
                bool state = ls.CheckCredentials(vm);
                if (state)
                {
                    Session["Login"] = vm.Login.UserName;
                }
                return RedirectToAction("Home", "Contact");
            }

            return View(vm);
        }

        public ActionResult Logout()
        {
            Session["Login"] = "Guest";
            return RedirectToAction("Home", "Contact");
        }
    }
}