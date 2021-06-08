using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace porteVar
{
    class ReshapeString
    {
        public static string Reshape(int n, string str)
            
        {
            //  avec la methode Replace de Regex
            //str = Regex.Replace(str, @"\s", "");
            // Avec la methode repplace de String
            str = str.Replace(" ", String.Empty);
             

            string[] tabReshape = new string[str.Length];
            int pas = n;
            for (int i = 0; i < str.Length-2*n; i++)
            {
                if(i== ((str.Length-1) -2*n))
                {
                    tabReshape[i] = str.Substring(str.Length-1);
                }
                else {
                    tabReshape[i] = str.Substring(i * n, n);
                }              
            }
            return tabReshape.ToString();
            //return 
            //    from st in str.Replace(" ", String.Empty)
            //    select  st.s
            //var list = new List<char>();
            ///IEnumerable<char> query = list.Where( c => c)
           /// list.Add(str.Split(','));

            

            //return str.Substring(n);



        }
    }
}
