using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Agetodays
{
    /// <summary>
    /// Description résumée de AgeTodaysWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    //[System.Web.Script.Services.ScriptService]
    public class AgeTodaysWebService : System.Web.Services.WebService
    {

        public AgeTodaysWebService() { }

        [WebMethod]
        public int converttodaysweb(int day, int month,int year)
        {
            DateTime dt = new DateTime(year, month, day);
            int datetodays = DateTime.Now.Subtract(dt).Days;
            return datetodays;
        }
    }
}
