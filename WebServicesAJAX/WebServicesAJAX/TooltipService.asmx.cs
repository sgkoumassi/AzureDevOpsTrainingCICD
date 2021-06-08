using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using System.Configuration;
using System.Data;

namespace WebServicesAJAX
{
    /// <summary>
    /// Description résumée de TooltipService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    [System.Web.Script.Services.ScriptService]
    public class TooltipService : System.Web.Services.WebService
    {
        [WebMethod]
        public void GetHelpTextByKey(string key)
        {
            Tooltip helpText = new Tooltip();

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetHelpTextByKey", con);
                cmd.CommandType = CommandType.StoredProcedure;
                var ParameterName = new SqlParameter
                {
                    ParameterName = "@HelpTextKey",
                    Value = key
                };
                cmd.Parameters.Add(ParameterName);
                con.Open();
                /*SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    helpText.Key = rdr["HelpTextKey"].ToString();
                    helpText.Text = rdr["HelpText"].ToString();
                }*/
                helpText.Text = cmd.ExecuteScalar().ToString();
                helpText.Key = key;
            }
            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(helpText));

        }
    }
}
