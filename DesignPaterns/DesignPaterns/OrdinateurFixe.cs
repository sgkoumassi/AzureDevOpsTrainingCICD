using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaterns
{
    public class OrdinateurFixe : Ordinateur
    {
        public CarteMere creeCarteMere(string modele, string chipset)
        {
            return new CarteMereFixe(modele, chipset);
        }

        public CarteGraphique creeCarteGraphique(string modele, string memoire, string chipset)
        {
            return new CarteGraphiqueFixe(modele, memoire, chipset);
        }
    }
}
