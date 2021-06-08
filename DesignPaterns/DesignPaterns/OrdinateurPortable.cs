using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaterns
{
    public class OrdinateurPortable : Ordinateur
    {
        public CarteMere creeCarteMere(string modele, string chipset)
        {
            return new CarteMerePortable(modele, chipset);
        }

        public CarteGraphique creeCarteGraphique(string modele, string memoire, string chipset)
        {
            return new CarteGraphiquePortable(modele, memoire, chipset);
        }
    }
}
