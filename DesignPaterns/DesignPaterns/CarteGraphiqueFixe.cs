using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaterns
{
    public class CarteGraphiqueFixe : CarteGraphique
    {
        protected String modele;
        protected String memoire;
        protected String chipset;

        public CarteGraphiqueFixe(String modele, String memoire,
            String chipset)
            : base(modele, memoire, chipset)
        {
            this.modele = modele;
            this.memoire = memoire;
            this.chipset = chipset;
        }

        public override void afficheDetail()
        {
            Console.WriteLine("Carte graphique pour fixe cree : " + modele +
                " , " + memoire + " Mo de RAM, chipset integre :" + chipset);
        }
    }
}
