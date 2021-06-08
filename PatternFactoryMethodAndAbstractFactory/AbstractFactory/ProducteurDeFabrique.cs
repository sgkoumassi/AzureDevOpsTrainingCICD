using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
   public  class ProducteurDeFabrique
    {
        public static FabriqueDeFormeAbstraite getFabrique(Boolean motifRond)
        {
            if (motifRond) return new FabriqueDeFormeRond();
            else return new FabriqueDeForme();
        }
    }
}
