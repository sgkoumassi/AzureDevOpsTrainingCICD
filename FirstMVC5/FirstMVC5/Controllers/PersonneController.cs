using FirstMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC5.Controllers
{
    public class PersonneController : Controller
    {
        // GET: Personne
        public ActionResult Index()
        {
            var p = new Personne
            {
                Nom = "Christophe",
                Email = "christophe@example.com",
                Age =27
            };
    
            return View(p);
        }
        public ActionResult Liste()
        {
            var personnes = new List<Personne>
            {
                new Personne  {Nom = "Dwigth", Age = 30,Email="dwight@exemple.com"},
                new Personne  {Nom = "Andy", Age = 35,Email="andy@exemple.com"},
                new Personne  {Nom = "Jim", Age = 33,Email="jim@exemple.com"},
            };

             return View(personnes);
        }
       
    }
}