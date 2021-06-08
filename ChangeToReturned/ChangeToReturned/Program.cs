/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeToReturned
{
    class Program
    {
       
public class Prefix
        {
            public static IEnumerable<string> Prefixes(IEnumerable<string> words, int length)
            {
                throw new InvalidOperationException("Waiting to be implemented.");
            }

            public static void Main(string[] args)
            {
     
                      Console.ReadLine();
            }
        }









/*

        long s = 18;
        Change m = Solution.OptimalChange(s);
        Console.WriteLine("Coin(s) 2£ : " + m.coin2);
        Console.WriteLine("Coin(s) 5£ : " + m.coin5);
        Console.WriteLine("Coin(s) 10£ : " + m.coin10);*/

        
       // }
    //}

    /* class Change
    {
        public long coin2 = 0;
        public long coin5 = 0;
        public long coin10 = 0;
    }



    class Solution
    {
    public static Change OptimalChange(long s)
      {
        var monaie = new Change();
        var c = s.ToString().Substring(s.ToString().Length - 1);
        if (s < 2)
        {
            return null;
        }
        else if (c == "6" || c == "8")
        {
            monaie.coin10 = s / 10;
            monaie.coin2 = (s % 10) / 2;
            return monaie;
        }
        else
        {
            monaie.coin10 = s / 10;
            monaie.coin5 = (s % 10) / 5;
            monaie.coin2 = ((s % 10) % 5) / 2;

            return monaie;
        }

      }
    }




//}*/
