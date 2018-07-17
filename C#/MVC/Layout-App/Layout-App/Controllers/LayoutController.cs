using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Layout_App.Controllers
{
    public class LayoutController :Controller
    {
        public ActionResult Index()
        {
            return View("Index","LayoutMaster");
        }

        public ActionResult Home()
        {
            return View("Home", "LayoutMaster");
        }

        public ActionResult About()
        {
            return View("About", "LayoutMaster");
        }

    }
}