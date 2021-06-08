using System;
using System.Collections.Generic;
using System.Text;

namespace porteVar
{
    class ReturnNextWeekOfDate
    {
        public static DateTime Nextweek7 ( DateTime date)
        {
            //// EN Js 
            //var mydayPlus7 = new Date(Number(date));
            //mydayPlus7.setDate(date.getDate() + 7);
            // return mydayPlus7;

            //En C#
     
            DateTime nextweek = date.AddDays(7);
            return nextweek ;
        }
    }
}
