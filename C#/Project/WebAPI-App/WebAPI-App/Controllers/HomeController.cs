using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebAPI_App.Controllers
{
    public class HomeController : System.Web.Http.ApiController
    {
       public IHttpActionResult Get()
        {
            return Ok("Get Called");
        }

        public IHttpActionResult Post()
        {
            return Ok("Post Called");
        }

        public IHttpActionResult Put()
        {
            return Ok("Put Called");
        }

        public IHttpActionResult Delete()
        {
            return Ok("Delete Called");
        }
    }
}