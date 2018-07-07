using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StartMVC_App.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "This is StartMVC-App";
        }

        public ContentResult About()
        {
            return Content("<h1>About View using ContentResult</h1>");
        }

        [Route("Home/Contact/{id?}")]
        public ContentResult Contact(int id=0)
        {         
            return Content("Contact with id :"+id);
        }

        public ContentResult Welcome(string Name)
        {
            if (Name == "")
                Name = "Anonymous";
            return Content("<H1>Welcome  " + Name+"</H1>");
        }

        public ActionResult Browse()
        {
            return View();
        }

        public ActionResult Address()
        {
            List<string> list = new List<string>{"Mumbai","Pune","Solapur" };
            ViewBag.Address = list;
            return View();
        }
    }
}