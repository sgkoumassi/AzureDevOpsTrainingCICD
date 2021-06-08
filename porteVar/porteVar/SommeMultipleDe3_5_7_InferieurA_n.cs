using System;
using System.Collections.Generic;
using System.Text;

namespace porteVar
{
    class SommeMultipleDe3Or5Or7OrInferieurA_n
    {
        public static int SomMutiple3Or5Or7InferieurA_n(int n)
        {
            int _sommeMultipleDe3_5_7_InferieurA_n = 0;
            if(n >= 0 && n < 1000) {
                for (int i = 1; i < n; i++)
                {
                    if (i%3==0 || i%5==0 || i % 7 == 0)
                    {
                        _sommeMultipleDe3_5_7_InferieurA_n += i;
                    }
                }
            }
            
            return _sommeMultipleDe3_5_7_InferieurA_n;
        }
    }
}
