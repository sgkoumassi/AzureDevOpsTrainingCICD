using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeWebApiService.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<ngEmployees> Get()
        {
            using(PachaDataFormationEntities entities = new PachaDataFormationEntities())
            {
               return entities.ngEmployees.ToList();
            }

        }

        public ngEmployees Get(string code)
        {
            using (PachaDataFormationEntities entities = new PachaDataFormationEntities())
            {
                return entities.ngEmployees.FirstOrDefault(e => e.code == code);
            }

        }
    }
}
