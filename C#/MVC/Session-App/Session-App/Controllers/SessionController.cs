using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Session_App.Models;


namespace Session_App.Controllers
{
    public class SessionController : Controller
    {
        // GET: Session
        public ActionResult Index()
        {
            IndexViewModel vm = new IndexViewModel();
            
            if (Session["count"] == null)
            {
                Session["count"] = 0;
            }

            vm.OldCount = (int)Session["count"];
            
            vm.NewCount = vm.OldCount + 1;

            Session["count"] = vm.NewCount;

            vm.SessionId = Session.SessionID.ToString();
            return View(vm);
        }
    }
}