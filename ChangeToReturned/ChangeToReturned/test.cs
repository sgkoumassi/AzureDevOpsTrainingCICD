using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 99099;
            int b = a / 10;
            int c = a % 10;
            int d = c / 5;
            int e = c % 5;
            int f = e / 2;
            string s = "toto";

            var hasSet = new HashSet<int>();
            var list = new List<int>(2);
            var m = new Dictionary<object, int>();
            var o1 = new object();
            var o2 = o1;
            m[o1] = 1;
            m[o2] = 2;
            hasSet.Add(1);
            hasSet.Add(1);
            hasSet.Add(2);
            list.Add(1);
            list.Add(1);
            list.Add(1);

            var digits = new List<List<int>> { new List<int> { 1, 2, 3 }, new List<int> { 5, 2, 3, 1, 1 } };
            var res = digits.SelectMany(x => x).Where(x => x != 2).GroupBy(x => x).Count();


           /* int[] number = { 3, 7, 9, 89, 4, 55, 98 };
            var strings = new List<string>() { "Gurt", "Lobster", "Litch", "Doe" };
            var filterStrings = new Answer().Filter(strings);

            //foreach(var str in filterStrings)
            //{
            //    Console.WriteLine(" the filtering list is bellow :  \n "+ str);
            //}
            //Console.WriteLine(" le plus grand nombre est {0}", FindLargest(number));*/

            Console.WriteLine(" s contient {0} carracteres ", s.Length);
            Console.WriteLine(" m[o1] vaut {0} ", m[o1]);
            Console.WriteLine(" m[o2] vaut {0} ", m[o2]);
            Console.WriteLine("hast contient {0} elements ", hasSet.Count);
            Console.WriteLine("list contient {0} elements ", list.Count);

            Console.WriteLine("resultat vaut " + res );
            var var = 2;


            /* Console.WriteLine(" ccoin10 = " + b);

             Console.WriteLine(c);

             Console.WriteLine(" coin5 = " + d);

             Console.WriteLine(e);

             Console.WriteLine(" coin2 = " + f);

             Console.WriteLine("Somme rendu = " + (10 * b + 5 * d + 2 * f));*/

            Console.ReadLine();
        }

       /* class Answer
        {
            public IEnumerable<string> Filter(List<string> strings)
            {
                var strings2 = new List<string>();
                foreach (var st in strings)
                {
                    var st1 = st.Substring(0, 1);
                    string lt = "L";
                    var st2 = st.Replace(st1, lt);
                    strings2.Add(st2);
                }

                var result =
                    from maList in strings2
                    orderby maList descending
                    select maList;

                return result;
            }
        }*/

     





    }
}
