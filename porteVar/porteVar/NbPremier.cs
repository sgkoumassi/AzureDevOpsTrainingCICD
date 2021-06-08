using System;
using System.Collections.Generic;
using System.Text;

namespace porteVar
{
    class NbPremier
    {
        public static bool IsPrime(int nb)
        {
            if (nb < 0)
                return IsPrime(-nb);
            else if (nb == 1)
                return false;
            else if (nb <= 3)
                return true;
            else
            {
                int sqrt_int = (int)Math.Floor(Math.Sqrt(nb));
                for (int i = 2; i <= sqrt_int; i++)
                {
                    if (nb % i == 0)
                        return false;
                }

                return true;
            }
        }
    }
}
