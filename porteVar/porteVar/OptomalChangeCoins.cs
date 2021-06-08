using System;
using System.Collections.Generic;
using System.Text;

namespace porteVar
{
      class Change
    {
        public long coin2 = 0;
        public long coin5 = 0;
        public long coin10 = 0;
    }

    class OptomalChangeCoins
    {
        public static Change OptimalChange(long s)
        {
            var monaie = new Change();
            var c = s.ToString().Substring(s.ToString().Length - 1);

            if (s <= 1 || s > (9223372036854775807)) return null;
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
}
