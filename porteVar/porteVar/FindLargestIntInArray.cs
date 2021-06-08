using System;
using System.Collections.Generic;
using System.Text;

namespace porteVar
{
    class FindLargestIntInArray
    {
        public static int FindLargest(int[] numbers)
        {
            int valMax = numbers[0];
            foreach (int nb in numbers)
            {
                if (nb > valMax) valMax = nb; 
            }
            return valMax;
            
        }
    }
}
