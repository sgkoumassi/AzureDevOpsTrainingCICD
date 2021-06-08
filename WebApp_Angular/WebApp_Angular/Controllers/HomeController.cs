using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp_Angular.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("Login");
        }
        [HttpPost]
        public ActionResult Index(string Username,string Password)
        {
            return View("Login");
        }

        
        public ActionResult MyPostIndex(string Username, string Password)
        {
            return View("Login");
        }
    }
}