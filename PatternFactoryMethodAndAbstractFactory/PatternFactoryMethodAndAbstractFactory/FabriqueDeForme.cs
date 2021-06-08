using System;
using System.Collections.Generic;
using System.Text;

namespace PatternFactoryMethod
{
    public class FabriqueDeForme
    {
        // Crée la forme en fonction du type
        public IForme getForme(string typeForme)
        {
            if (typeForme == null) return null;
            if(string.Equals(typeForme, "CERCLE", StringComparison.OrdinalIgnoreCase))
            {
                return new Cercle();
            } else
                if (string.Equals(typeForme, "RECTANGLE", StringComparison.OrdinalIgnoreCase))
            {
                return new Rectangle();
            }else
                if (string.Equals(typeForme, "CAREE", StringComparison.OrdinalIgnoreCase))
            {
                return new Caree();
            }
            return null;
        }
    }
}
