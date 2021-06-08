using System;
using System.Collections.Generic;
using System.Text;

namespace porteVar
{
    class Factoriel_NombrePaireImpaireNombrePremier
    {
        // Factoriel d'un nombre avec la methode iterative
        public static int Factorielle(int a)
        {
            int total = 1;
            for (int i = 1; i <= a; i++)
            {
                total *= i;
            }
            return total;
        }
        // Factoriel d'un nombre avec la methode recurssive
        public static int FactorielleRecur(int a)
        {
            if (a <= 1)
                return 1;
            return a * FactorielleRecur(a - 1);

        }
        // Nombre paire et impaire
        public static string checkNbPair_impair(int n)
        {
            return n % 2 == 0 ? "pair" : "impair";
           
        }

        // Nombre premier
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
                int sqrt_int = (int)Math.Sqrt(nb);
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
