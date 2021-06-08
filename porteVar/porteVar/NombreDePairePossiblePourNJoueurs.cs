using System;
using System.Collections.Generic;
using System.Text;

namespace porteVar
{
    class NombreDePairePossiblePourNJoueurs
    {
        public static int CountNombreDePairePossible(int n)
        {

            int _nombreDePairePossible = 0;
            if (n >= 2 && n <= 10000)
            {
                for (int i = 1; i < n; i++)
                {
                    _nombreDePairePossible += (n - i);
                }
                return _nombreDePairePossible;
            }
            else return 0;
           
        }
    }
}
