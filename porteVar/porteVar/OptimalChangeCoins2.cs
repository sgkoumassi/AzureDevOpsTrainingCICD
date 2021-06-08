using System;
using System.Collections.Generic;
using System.Text;

namespace porteVar
{
    class Change2
    {
        public long bill10 = 0;
        public long bill5 = 0;
        public long coin2 = 0;
    }
    class OptimalChangeCoins2
    {
        public static Change2 OptimalChange2(long s)
        {
            Change2 change = new Change2();
            if (s <= 1 || s > (9223372036854775807)) return null;
            else
            {
                change.bill10 = (int) s/ 10;
                change.bill5 = (int)(s % 10) / 5;
                change.coin2 =(int) ((s % 10)%5)/2;
                return change;
            }

        }
    }
}
