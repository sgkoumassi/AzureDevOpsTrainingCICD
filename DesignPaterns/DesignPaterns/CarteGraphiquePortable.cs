using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaterns
{
    public class CarteGraphiquePortable : CarteGraphique
    {
        protected String modele;
        protected String memoire;
        protected String chipset;

        public CarteGraphiquePortable(String modele, String memoire,
            String chipset)
            : base(modele, memoire, chipset)
        {
            this.modele = modele;
            this.memoire = memoire;
            this.chipset = chipset;
        }

        public override void afficheDetail()
        {
            Console.WriteLine("Carte graphique pour portable cree : " + modele +
                " , " + memoire + " Mo de RAM, chipset integre :" + chipset);
        }
    }
}
