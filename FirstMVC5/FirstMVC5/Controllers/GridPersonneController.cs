using FirstMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC5.Controllers
{
    public class GridPersonneController : Controller
    {
        // GET: GridPersonne
        public ActionResult Grid()
        {

            var Gpersonnes = new List<GridPersonne>
            {
                new GridPersonne  {Nom = "Dwigth", Age = 30,Email="dwight@exemple.com"},
                new GridPersonne  {Nom = "Andy", Age = 35,Email="andy@exemple.com"},
                new GridPersonne  {Nom = "Jim", Age = 33,Email="jim@exemple.com"},
                new GridPersonne  {Nom = "Stanlay", Age = 37,Email="Stanlay@exemple.com"},
                new GridPersonne  {Nom = "Idriss", Age = 31,Email="Idriss@exemple.com"},
                new GridPersonne  {Nom = "Souley", Age = 32,Email="Souley@exemple.com"},
                new GridPersonne  {Nom = "Gani", Age = 60,Email="Gani@exemple.com"},
                new GridPersonne  {Nom = "Mamane", Age = 13,Email="Mamane@exemple.com"},
                new GridPersonne  {Nom = "Hawa", Age = 23,Email="Hawa@exemple.com"},
                new GridPersonne  {Nom = "Razak", Age = 18,Email="Razak@exemple.com"},
                new GridPersonne  {Nom = "Doudou", Age = 20,Email="Doudou@exemple.com"},
            };

            return View(Gpersonnes);
        }
    }
}