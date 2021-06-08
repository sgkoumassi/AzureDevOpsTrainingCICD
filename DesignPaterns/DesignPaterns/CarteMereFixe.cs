using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaterns
{
    public class CarteMereFixe : CarteMere
    {
        protected String modele;
        protected String chipset;

        public CarteMereFixe(String modele, String chipset)
            : base(modele, chipset)
        {
            this.modele = modele;
            this.chipset = chipset;
        }

        public override void afficheDetail()
        {
            Console.WriteLine("Carte mere pour fixe cree : " + modele +
                " , chipset integre :" + chipset);
        }
    }
}
