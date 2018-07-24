using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Banking_User.Controllers
{
    public class UserController : Controller
    {

        public ActionResult Account()
        {
            return View();
        }
    }
}