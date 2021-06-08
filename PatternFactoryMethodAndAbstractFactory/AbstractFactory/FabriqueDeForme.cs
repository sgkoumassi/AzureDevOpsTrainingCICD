using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class FabriqueDeForme: FabriqueDeFormeAbstraite
    {
        // Crée la forme en fonction du type
        public override IForme getForme(string typeForme)
        { 
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
