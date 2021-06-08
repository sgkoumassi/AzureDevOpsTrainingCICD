using System;

using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static bool anagramme(string str1, string str2)
        {
            //abccd - acdbc  manoir - manoire => false  manoir - manoit => false  manoir - manoi => false
            int increment = 0;
            HashSet<char> HsetStr1 = new HashSet<char>();
            HashSet<char> HsetStr2 = new HashSet<char>();
            foreach(char c in str1)
            {
                HsetStr1.Add(c);
            }
            foreach (char c in str2)
            {
                HsetStr2.Add(c);
            }
            if (str1.Length==str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {

                    if (str1.Contains(str2[i])) increment++;
                }
            }
            if (increment == str2.Length && HsetStr1.SetEquals(HsetStr2))
            {
                return true;
            }
            else return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(anagramme("abccd", "acdbc"));
            Console.ReadKey();
        }
    }
}
