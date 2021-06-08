using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaterns
{
    public interface Ordinateur
    {
        CarteMere creeCarteMere(String modele, String chipset);

        CarteGraphique creeCarteGraphique(String modele, String memoire,
            String chipset);
    }
}
