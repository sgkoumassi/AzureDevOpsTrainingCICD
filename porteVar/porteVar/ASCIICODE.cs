using System;
using System.Collections.Generic;
using System.Text;

namespace porteVar
{
    public class ASCIICODE
    {
        public static void ScanChar()
        {
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(28591);
            for (int i = 1; i < 256; i++)
            {
                Console.WriteLine(i + " = " + (char)i);
                if (i % 16 == 0)
                {
                    Console.WriteLine("Please press any key to turn page");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

    }
}
