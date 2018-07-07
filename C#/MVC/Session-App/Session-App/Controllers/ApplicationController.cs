using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Session_App.Models;

namespace Session_App.Controllers
{
    public class ApplicationController : Controller
    {
        // GET: Application
        public ActionResult Index()
        {

            IndexViewModel vm = new IndexViewModel();
            if (this.HttpContext.Application["count"] == null)
            {
                this.HttpContext.Application["count"] = 0;
            }
            vm.OldCount = (int)this.HttpContext.Application["count"];

            vm.NewCount = vm.OldCount + 1;

            this.HttpContext.Application["count"] = vm.NewCount;

            return View(vm);
        }
    }
}