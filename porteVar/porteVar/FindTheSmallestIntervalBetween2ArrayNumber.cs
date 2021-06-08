using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace porteVar
{
    class FindTheSmallestIntervalBetween2ArrayNumber
    {
        public static int FindSmallestInterval(int[] array)
        {
           
            List<int> maList = array.OrderByDescending(n=> n).ToList();
            int smallestInterval = Math.Abs(maList[0] - maList[1]);
            for (int i = 1; i <= maList.Count - 1; i++)
            {

                if (Math.Abs(maList[i - 1] - maList[i]) < smallestInterval)
                {
                    smallestInterval = Math.Abs(maList[i - 1] - maList[i]);
                }

            }
            return smallestInterval;
        }

        public static int MagicStone(List<int> stones)
        {
            int minStone = 0;
            ILookup<int, int> dicstones = stones.ToLookup(x => x);
            minStone = dicstones.GroupBy(p => p.Sum()).Count();
            return minStone;
        }
    }
}
