using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserModal.BL;

namespace WebApWith_StoreProcedure.Controllers
{

    public class UserController : Controller
    {
        UserBusnessLogic Userbl = new UserBusnessLogic();
        // GET: User
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User User)
        {
            string message = "";
            if (ModelState.IsValid)
            {
                if (Userbl.CheckUserLogin(User) > 0)
                {
                    message = "success";
                }
                else
                {
                    message = "Username Or Password Is Incorrect  !!";

                }
            }
            else
            {
                message = "All Fields Required !!";
            }
            if (Request.IsAjaxRequest())
            {
                return Json(message, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return RedirectToAction("Index", "Homme");
            }
        }
    }
}