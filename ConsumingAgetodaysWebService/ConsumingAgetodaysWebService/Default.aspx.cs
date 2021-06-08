using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumingAgetodaysWebService
{
    public partial class Default : System.Web.UI.Page
    {
        protected void button1_Click(object sender, EventArgs e)
        {
            localhost.AgeTodaysWebService age = new localhost.AgeTodaysWebService();
            int day = int.Parse(textbox1.Text.ToString());
            int month = int.Parse(textbox2.Text.ToString());
            int year = int.Parse(textbox3.Text.ToString());

            int a = age.converttodaysweb(day, month, year);

            label1.Text = "Your are currently" + "" + a.ToString() + " " + "Days old";

        }
    }
}