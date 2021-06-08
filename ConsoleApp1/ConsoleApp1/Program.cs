using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 2, 3, 1, 2, 4, 4, 4 };
            int count = 0;
            var list = array.GroupBy(x =>
            {
                count++;
                return x;
            });

            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
