using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.DataBase;
using UserService.DataBase.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // Add the databaseContex
        DatabaseContext db;
        public UserController()
        {
            db = new DatabaseContext();
        }

        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return  db.Users.ToList();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}", Name ="Get")]
        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] User model)
        {
            try
            {
                db.Users.Add(model);
                db.SaveChanges();

                // Using Htpp methode to return statuscode that notified the user has been added
                return StatusCode(StatusCodes.Status201Created, model);

            }
            catch (Exception ex)
            {

               return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        } 
    }
}
