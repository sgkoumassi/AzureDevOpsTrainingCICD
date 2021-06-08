using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorielleTDD
{
    class SommeArrayOfString
    {
        public static string Sum(params string[] numbers)
         {
          double total = 0;

          foreach (string number in numbers)
          {
            total = total + Convert.ToDouble(number);
          }

          return total.ToString();
         }
    }
}
