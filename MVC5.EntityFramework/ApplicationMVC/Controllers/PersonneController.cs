using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicationMVC.Controllers
{
    public class PersonneController : Controller
    {
        private BDMVC5Entities contextEF = new BDMVC5Entities();
        public ActionResult Liste()
        {
            var personnes = contextEF.Personne.ToList();
            return View(personnes);
        }
    }
}