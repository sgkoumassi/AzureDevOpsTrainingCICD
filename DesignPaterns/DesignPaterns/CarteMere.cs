using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaterns
{
    public abstract class CarteMere
    {
        protected String modele;
        protected String chipset;

        public CarteMere(String modele, String chipset)
        {
            this.modele = modele;
            this.chipset = chipset;
        }

        public abstract void afficheDetail();
    }
}
