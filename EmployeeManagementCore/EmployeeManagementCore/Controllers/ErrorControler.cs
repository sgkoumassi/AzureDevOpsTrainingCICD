﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagementCore.Controllers
{
    public class ErrorControler : Controller
    {
   
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Sorry, the ressource you requested could not be found";
                    break;
            }
            return View("NotFound");
        }
        [Route("Error")]
        [AllowAnonymous]
        public IActionResult Error()
        {
            var execeptionDeyails = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            ViewBag.ExceptionPath = execeptionDeyails.Path;
            ViewBag.ExceptionMessage = execeptionDeyails.Error.Message;
            ViewBag.StackTrace = execeptionDeyails.Error.StackTrace;

            return View("Error");
        }
    }
}
