using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WelcomeMVC_App.Controllers
{
    public class HomeController : System.Web.Mvc.Controller
    {
        public string Index()
        {
            return "<h1>Index page of HomeController</h1>";
        }

    }
}