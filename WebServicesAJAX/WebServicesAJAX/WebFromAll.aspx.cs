using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServicesAJAX
{
    public partial class WebFromAll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ServiceReferenceCountries.StudentsServiceSoapClient clientSoap = new ServiceReferenceCountries.StudentsServiceSoapClient();

            Repeater1.DataSource=clientSoap.GetCountries();
            Repeater1.DataBind();


            ListView1.DataSource = clientSoap.GetCountries();
            ListView1.DataBind();

            //tabs
            ServiceReferenceCountries.Country[] tabCountrie= clientSoap.GetCountries();
            Repeater2.DataSource = tabCountrie;
            Repeater2.DataBind();
            Repeater3.DataSource = tabCountrie;
            Repeater3.DataBind();


        }
    }
}