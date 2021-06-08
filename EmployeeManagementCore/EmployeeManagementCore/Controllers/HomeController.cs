using EmployeeManagementCore.Models;
using EmployeeManagementCore.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IHostingEnvironment hostingEnvironment;

        public HomeController(IEmployeeRepository employeeRepository,
          /*provide the absolute physcal path of the wwwroot folder */
          IHostingEnvironment hostingEnvironment)
        {
            _employeeRepository = employeeRepository;
            this.hostingEnvironment = hostingEnvironment;
        }
        //public ViewResult Index()
        //{
        //    var model = _employeeRepository.GetAllEmployee();
        //    return View(model);
        //}

        public ViewResult Details(int? id)
        {
           //throw new Exception("Error Test in details view");
            // passing data using ViewData methode
            //Employee model = _employeeRepository.GetEmployee(1);
            /*ViewData["Employee"] = model;
            ViewData["PageTitle"] = "Employee Details";
            return View()
            */

            // passing data using ViewBag methode 
            //Employee model = _employeeRepository.GetEmployee(1);
            /* ViewBag.Employee = model;
             ViewBag.PageTitle = "Employee Details";
             return View(); */

            // passing data using Strongly typed view methode : 
            // here we pass the model object to the view as parameter
            //Employee model = _employeeRepository.GetEmployee(1);
            // ViewBag.PageTitle = "Employee Details";
            // return View(model);

            // passing data using ViewModel methode 
            HomeDetailsViewModel homeDeailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id ?? 1),
                PageTitle = "Employee Details"
            };
            return View(homeDeailsViewModel);
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if(model.Photos!=null && model.Photos.Count >0)
                {
                    foreach(IFormFile photo in model.Photos)
                    {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    photo.CopyTo(new FileStream(filePath, FileMode.Create));
                    }
                }
                Employee newEmployee = new Employee
                {
                    Name = model.Name,
                    Email = model.Email,
                    Department = model.Department,
                    PhotoPath = uniqueFileName

                };
                _employeeRepository.Add(newEmployee);
                return RedirectToAction("details", new { id = newEmployee.Id });
            }
            return View();
        }
    }
}
