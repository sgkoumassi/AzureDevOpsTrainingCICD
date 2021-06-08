using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Script.Serialization;

namespace WebServicesAJAX
{
    /// <summary>
    /// Description résumée de MenuHandler
    /// </summary>
    public class MenuHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            List<Menu> listMenu = new List<Menu>();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetMenuData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Menu menu = new Menu();
                    menu.Id = Convert.ToInt32(reader["Id"]);
                    menu.MenuText = reader["MenuText"].ToString();
                    menu.ParentId = reader["ParentId"] != DBNull.Value ? Convert.ToInt32(reader["ParentId"]) : (int?)null;
                    menu.Active = Convert.ToBoolean(reader["Active"]);
                    listMenu.Add(menu);

                }
            }
            List<Menu> menuTree = GetMenuTree(listMenu, null);
            JavaScriptSerializer js = new JavaScriptSerializer();
            context.Response.Write(js.Serialize(menuTree));
        }

        private List<Menu> GetMenuTree(List<Menu> list,int? parentId)
        {
            return list.Where(x => x.ParentId == parentId).Select(x => new Menu()
            {
                Id = x.Id,
                MenuText = x.MenuText,
                ParentId = x.ParentId,
                Active = x.Active,
                List=GetMenuTree(list,x.Id)         

            }).ToList();
        }


        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}