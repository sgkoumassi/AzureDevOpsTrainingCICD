using System;
using System.Collections.Generic;
using System.Text;

namespace porteVar
{
    class SomOfArrayElementsWhichIndexIsIn2Interval
    {
       
        public static int Calc(int[] array, int n1, int n2)
        {
            int somArray = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(n1<=i && i<=n2)
                {
                    somArray= somArray+array[i];
                }
            }

            return somArray;
            
        }
    }
}
