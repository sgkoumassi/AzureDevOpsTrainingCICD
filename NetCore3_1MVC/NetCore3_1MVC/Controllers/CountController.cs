using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore3_1MVC.Controllers
{
    public class CountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
