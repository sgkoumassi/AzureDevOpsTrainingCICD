using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace porteVar
{
    class SomeArrayOfString
    {
        private static void CallTryParse(string stringToConvert, NumberStyles styles)
        {
            CultureInfo provider;

            // If currency symbol is allowed, use en-US culture.
            if ((styles & NumberStyles.AllowCurrencySymbol) > 0)
                provider = new CultureInfo("en-US");
            else
                provider = CultureInfo.InvariantCulture;

            bool success = Int32.TryParse(stringToConvert, styles,
                                         provider, out int number);
            if (success)
                Console.WriteLine("Converted '{0}' to {1}.", stringToConvert, number);
            else
                Console.WriteLine("Attempted conversion of '{0}' failed.",
                                  Convert.ToString(stringToConvert));
        }
        public static string Sum(params string[] numbers)
        {
            double total = 0;

            foreach (string value in numbers)
            {
                total = total + Convert.ToDouble(value, CultureInfo.InvariantCulture);
            }

            return total.ToString();

            //    string numericString;
            //    NumberStyles styles;
            //    styles = NumberStyles.Integer | NumberStyles.AllowDecimalPoint | NumberStyles.None;

            //    foreach (string value in numbers)
            //    {

            //        try
            //        {
            //            int number = Int32.Parse(value, (NumberStyles.Integer | NumberStyles.AllowDecimalPoint | NumberStyles.None));
            //            total = total + number;
            //        }
            //        catch (FormatException)
            //        {
            //            Console.WriteLine("{0}: Bad Format", value);
            //        }
            //        catch (OverflowException)
            //        {
            //            Console.WriteLine("{0}: Overflow", value);
            //        }
            //    }
            //    return total.ToString();
            }
        }
    }
