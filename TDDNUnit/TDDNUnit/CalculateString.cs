using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace TDDNUnit
{
   public class CalculateString
    {
        char[] separator = new char[] { '\n', ',' };
        public int calculateStr(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return 0;
            }
            else
            {
                return getSum(input);
            }
        }
        private int getSum(string input)
        {
            return input.ToString().Split(separator).Select(Int32.Parse).Sum();
            //int total = 0;

            //foreach (string value in numbers)
            //{
            //    total += Int32.Parse(value);
            //}

            //return total;
        }
    }
}
