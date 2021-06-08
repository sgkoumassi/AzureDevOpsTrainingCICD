using System;
using System.Collections.Generic;
using System.Text;

namespace porteVar
{
    class CalculateTotalPrice
    {
        public static long CalculateToatalPriceDiscount(long[] listProduit, long discount)
        {
            long somListProduit = 0;
            int prinxVenteTotal = 0;
            for(int i=1; i<=listProduit.Length-1; i++)
            {
                if (listProduit.Length < 0 || listProduit.Length > 100 || listProduit[i] < 0 || listProduit[i] > 100000) return 0;
            }
            
            for (int i=0; i <= listProduit.Length - 1; i++)
            {
                somListProduit += listProduit[i];
            }
            if (discount >= 100) return somListProduit;
            
                discount = somListProduit * discount / 100;
            prinxVenteTotal = (int)Math.Floor((decimal)(somListProduit - discount));
            return  prinxVenteTotal;

        }
        
    }
}
