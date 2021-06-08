using FirstMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC5.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult Index()
        {
            List<Myshop> ItemList = new List<Myshop>();

            ItemList.Add(new Myshop { ItemId = 1, ItemName = "Rice", IsAvailable = true });
            ItemList.Add(new Myshop { ItemId = 2, ItemName = "Pulse", IsAvailable = false });
            ItemList.Add(new Myshop { ItemId = 3, ItemName = "Salt", IsAvailable = false });
            ItemList.Add(new Myshop { ItemId = 4, ItemName = "Suggar", IsAvailable = true });
            ItemList.Add(new Myshop { ItemId = 5, ItemName = "Soap", IsAvailable = false });
            ItemList.Add(new Myshop { ItemId = 6, ItemName = "Book", IsAvailable = true });

            ViewBag.ItemList = ItemList;

            return View();
        }


        [HttpPost]
        public JsonResult SaveList(string ItemList)
        {
            string[] arr = ItemList.Split(',');
            foreach (var id in arr)
            {
                var currentId = id;
            }
            return Json("", JsonRequestBehavior.AllowGet);
        }
    }
}