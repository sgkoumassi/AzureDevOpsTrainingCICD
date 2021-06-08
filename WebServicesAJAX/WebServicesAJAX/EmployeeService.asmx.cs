using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Serialization;
using System.Collections;

namespace WebServicesAJAX
{
    /// <summary>
    /// Description résumée de EmployeeService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    [System.Web.Script.Services.ScriptService]
    public class EmployeeService : System.Web.Services.WebService
    {
        [WebMethod]
        public Employee GetEmployeeById(int Id)
        {
            Employee employee = new Employee();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetEmployeeById", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameterId = new SqlParameter();
                parameterId.ParameterName = "@Id";
                parameterId.Value = Id;
                cmd.Parameters.Add(parameterId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    employee.Id = Convert.ToInt32(reader["Id"]);
                    employee.Name = reader["Name"].ToString();
                    employee.Gender = reader["Gender"].ToString();
                    employee.Salary = Convert.ToInt32(reader["Salary"]);

                }
            }
            // We can also return a json object y using the serialzer with the code bellow : so the return type 
            // of the web method shoul be void
            /*    
             *     JavaScriptSerializer js = new JavaScriptSerializer();
                   Context.Response.Write(js.Serialize(employee));    */

            return employee;
        }
        // this web methode will add an employee in the database
        [WebMethod]
        public void GetEmployees()
        {
            List<Employee> listEmployees = new List<Employee>();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetEmployees", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.Id = Convert.ToInt32(reader["Id"]);
                    employee.Name = reader["Name"].ToString();
                    employee.Gender = reader["Gender"].ToString();
                    employee.Salary = Convert.ToInt32(reader["Salary"]);
                    listEmployees.Add(employee);

                }
            }
                         
            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(listEmployees));   
        }

        // this web methode will load data from the database using the scrollbar position
        [WebMethod]
        public void LoadEmployeesWithScrBar(int pageNumber, int pageSize)
        {
            List<Employee> listEmployees = new List<Employee>();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spLoadEmployeeWithScrBar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter()
                {
                     ParameterName = "@PageNumber",
                     Value = pageNumber
                });

                cmd.Parameters.Add(new SqlParameter()
                {
                     ParameterName = "@PageSize",
                     Value = pageSize
                });
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.Id = Convert.ToInt32(reader["Id"]);
                    employee.Name = reader["Name"].ToString();
                    employee.Gender = reader["Gender"].ToString();
                    employee.Salary = Convert.ToInt32(reader["Salary"]);
                    listEmployees.Add(employee);

                }
            }
           
            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(listEmployees));
        }

        // this web methode return a json  array object
        [WebMethod]
        public void AddEmployees( Employee emp)
        {
 
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spInsertEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@Name",
                    Value = emp.Name
                });
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@Gender",
                    Value = emp.Gender
                });
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@Salary",
                    Value = emp.Salary
                });
                con.Open();
                cmd.ExecuteNonQuery();
               

             }
        }

        //[WebMethod]
        public bool CheckIfUserNameExist(string userName)
        {
 
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spCheckIfUserNameExist", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@UserName",
                    Value = userName
                });
                
                con.Open();
               return Convert.ToBoolean(cmd.ExecuteScalar());
            }

        }

        [WebMethod]
        public void GetAvailableUserName(string availableUserName)
        {
            Resgistration resgistration = new Resgistration();
            
            resgistration.UserNameInUse = false;

            while(CheckIfUserNameExist(availableUserName))
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 100);
                availableUserName += randomNumber.ToString();
                resgistration.UserNameInUse =true;
            }

            resgistration.UserName = availableUserName;

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(resgistration));
            
        }

        // this web methode will retrieve country from BD
        [WebMethod]
        public void GetCountry(string term)
        {
            List<CountryAndFrags> listCountries = new List<CountryAndFrags>();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetCountriesAndFlags", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramName = new SqlParameter()
                {
                    ParameterName = "@Name",
                    Value = term
                };
                cmd.Parameters.Add(paramName);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CountryAndFrags country = new CountryAndFrags();
                    country.Id = Convert.ToInt32(reader["Id"]);
                    country.Name = reader["Name"].ToString();
                    country.FlagPath = reader["FlagPath"].ToString();
                    
                    listCountries.Add(country);

                }
            }

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(listCountries));
        }


        [WebMethod]
        public void GetAllContact()
        {
            List<Contact> listContact = new List<Contact>();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetAllContact", con);
                cmd.CommandType = CommandType.StoredProcedure;            
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Contact contact = new Contact();
                    contact.ContactId = Convert.ToInt32(reader["ContactId"]);
                    contact.Titre = reader["Titre"].ToString();
                    contact.Nom = reader["Nom"].ToString();
                    contact.Prenom = reader["Prenom"].ToString();
                    contact.Email = reader["Email"].ToString();
                    contact.HomeTelephone = Convert.ToInt32(reader["Telephone"]);
                    contact.Sexe = reader["Sexe"].ToString();
                    contact.Telephone = Convert.ToInt32(reader["Portable"]);

                    listContact.Add(contact);

                }
            }

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(listContact));
        }


    }
}
