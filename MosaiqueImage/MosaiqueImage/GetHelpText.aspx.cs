using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Script.Serialization;
using System.Xml.Serialization;


public partial class GetHelpText :  System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //divResult.InnerText = GetHelpTextByKey(Request["HelpTextKey"]);
        /* =============================================
      // Json Serialization 
      JavaScriptSerializer js = new JavaScriptSerializer();
          string jsonString = js.Serialize(GetHelpTextByKey(Request["HelpTextKey"]));
          Response.Write(jsonString);*/

        // XLM serialization
        Response.ContentType = "text/xml";
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(HelpText));
        xmlSerializer.Serialize(Response.OutputStream, GetHelpTextByKey(Request["HelpTextKey"]));


    }

   // private string GetHelpTextByKey(string key)
     private HelpText GetHelpTextByKey(string key)
        {
            //string helpText = "";
            HelpText helpText = new HelpText();

        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        using (SqlConnection con = new SqlConnection(cs))
        {
            SqlCommand cmd = new SqlCommand("spGetHelpTextByKey",con);
            cmd.CommandType = CommandType.StoredProcedure;
            var ParameterName = new SqlParameter
            {
                   ParameterName = "@HelpTextKey",
                    Value =key
             };
            cmd.Parameters.Add(ParameterName);
            con.Open();
            helpText.Text = cmd.ExecuteScalar().ToString();
            helpText.Key = key;
            }

        return helpText;
    }
}
