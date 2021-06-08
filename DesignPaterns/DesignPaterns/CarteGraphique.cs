using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaterns
{
    public abstract class CarteGraphique
    {
        protected String modele;
        protected String memoire;
        protected String chipset;

        public CarteGraphique(String modele, String memoire,
            String chipset)
        {
            this.modele = modele;
            this.memoire = memoire;
            this.chipset = chipset;
        }

        public abstract void afficheDetail();
    }
}
