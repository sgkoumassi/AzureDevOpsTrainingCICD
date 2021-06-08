using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Web.Script.Serialization;
using System.Collections;
using System.Configuration;

namespace WebServicesAJAX
{
    /// <summary>
    /// Description résumée de StudentsService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    [System.Web.Script.Services.ScriptService]
    public class StudentsService : System.Web.Services.WebService
    {

        [WebMethod]
        public List<string> GetStudentNames(string term)
        {

            List<string> listStudents = new List<string>();

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetStudentNames", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@term",
                    Value = term

                });
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listStudents.Add(reader["Name"].ToString());

                }
            }


            return listStudents;
        }

        [WebMethod]
        public List<Country> GetCountries()
        {

            List<Country> lisCountries = new List<Country>();

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetCountries", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Country country = new Country();
                    country.Id = Convert.ToInt32(reader["Id"]);
                    country.Name = reader["Name"].ToString();
                    country.CountryDescription = reader["CountryDescription"].ToString();
                    lisCountries.Add(country);

                }
            }

            return lisCountries;
        }


    }
}
