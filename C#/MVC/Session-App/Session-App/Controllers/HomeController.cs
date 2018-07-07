using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Session_App.Models;

namespace Session_App.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Summary()
        {
            SummaryViewModel vm = new SummaryViewModel();
            if (this.HttpContext.Application["count"] == null)
            {
                this.HttpContext.Application["count"] = 0;
            }
            vm.ApplicationValue = (int)this.HttpContext.Application["count"] ;


            if (Session["count"] == null)
            {
                Session["count"] = 0;
            }
            vm.SessionValue = (int)Session["count"];
            return View(vm);
        }
    }
}