using ShopingCart_App_Refactored_.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopingCart_App_Refactored_.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Cart()
        {
            CartViewModel vm = new CartViewModel();
            return View(vm);
        }
    }
}