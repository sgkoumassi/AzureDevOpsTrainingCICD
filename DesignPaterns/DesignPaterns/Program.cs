using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaterns
{
    class Program
    {
        static void Main(string[] args)
        {

            Ordinateur ordinateur;

            // Stock de cartes meres et cartes graphiques
            CarteGraphique[] carteGraphique = new CarteGraphique[10];
            CarteMere[] carteMere = new CarteMere[10];

            // Un client arrive et passe commande d'un Ordinateur
            Console.WriteLine("Voulez-vous commander un " +
            "ordinateur fixe (1) ou portable (2)?");
            String choix = Console.ReadLine();

            if (choix.Equals("1"))
            {
                ordinateur = new OrdinateurFixe();
            }
            else
            {
                ordinateur = new OrdinateurPortable();
            }

            carteGraphique[0] = ordinateur.creeCarteGraphique("modele1", "512", "chipset32");
            carteMere[0] = ordinateur.creeCarteMere("modele1", "chipset32");

            Console.WriteLine("Votre demande a&#160; ete traitee.");
            carteGraphique[0].afficheDetail();
            carteMere[0].afficheDetail();
            Console.ReadKey();


        }
    }
}
