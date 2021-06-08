using System;
using System.Collections.Generic;
using System.Text;

namespace porteVar
{
    public class Duodigit
    {
        /*
         * // Calcule le nbre d'occurence d'un char dans une chaine
        public static int nbOccurence( char[] tabc, char c)
        {
            int ocChar = 0;
            foreach (char ch in tabc)
            {
                if (ch == c) ocChar++;
            }
            return ocChar;
        }*/
   

        public static int Isduogiti(int nb)
        {
            string val = nb.ToString();
            var hashSet = new HashSet<char>();
             for (int i = 0; i < val.Length; i++)
             {
                hashSet.Add(val[i]);
               }
             
            return (hashSet.Count>2) ? 0: 1;
             
        }
    }
}
