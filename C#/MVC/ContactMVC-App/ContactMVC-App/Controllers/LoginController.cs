using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactMVC_App.Models;
using ContactMVC_App.Services;

namespace ContactMVC_App.Controllers
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
                    Session["Login"] = vm.UserName;
                }
                return RedirectToAction("Home","Contact");
            }
               
            return View(vm);
        }

        public ActionResult Logout() {
            this.HttpContext.Application["Login"] = "Guest";
            return RedirectToAction("Home", "Contact");
        }
    }
}