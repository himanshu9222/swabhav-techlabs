using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_View_Demo_App.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string MyController()
        {
            return "Hi i am HomeController";
        }

        public ActionResult MyView()
        {
            return View();
        }
    }
}