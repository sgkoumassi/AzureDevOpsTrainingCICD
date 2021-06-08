using FirstMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC5.Controllers
{
    public class EditPersonneController : Controller
    {
        // GET: EditPersonne
        [HttpGet]
        public ActionResult Edit()
        {
                return View();
        }
        [HttpPost]
        public ActionResult Edit(EditPersonne p)
        {
            if (!ModelState.IsValid)
            {
                return View(p);
            }
            return null;
        }
    }

 
}