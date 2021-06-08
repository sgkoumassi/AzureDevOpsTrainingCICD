using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateUses
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu[] menuPrincipal = CreerMenu();
            for (; ; )
            {
                AfficherMenu(menuPrincipal);
                int choix = LireChoix(menuPrincipal.Length);
                Menu entree = menuPrincipal[choix - 1];
                entree.Effectuer();
            }
        }

  
        static void Echo(Menu m) => Console.WriteLine($"vous avez choisi '{m.Titre}'");
        static void Quitter() => Environment.Exit(0);
    
        static Menu[] CreerMenu()
        {
            MessageAleatoire proverbes = new MessageAleatoire(new string[]
            {
"Un jour l'amour a dit à l'amitié : Pourquoi existes-tu puisque je suis là ?\n" +
"L'amitié lui répond : Pour amener un sourire là ou tu as laissé des larmes.",
"S'aimer soi-même est le début d'une histoire d'amour qui durera toute une vie.",
@"Le secret du bonheur en amour, ce n'est pas d'être aveugle 
mais de savoir fermer les yeux quand il le faut."
            });
            MessageAleatoire dictons = new MessageAleatoire(new string[]
            {
"La vie est merveilleuse, croquons-la à pleines dents",
"La vie, c'est la minute où nous cherchons tous à être heureux..",
" L'existence est une lutte de tous les jours, un combat permanent.",
"L'espérance est la morphine de la vie"
            });
            string prenom = " Soul";
            return new Menu[] {
                new Menu("Dire 'bonjour'", () => Console.WriteLine("Bonjour tout le monde")),
                new Menu("Saisie du prenom d'utilisateur ", () =>{Console.Write("votre prenom: "); prenom =Console.ReadLine();}),
                new Menu("Bonjour personnalisé", delegate(){Console.WriteLine($"Bonjour {prenom} !!"); }),
                new Menu("Echo 1", Echo),
                new Menu("Echo 2", Echo),
                new Menu("proverbe du jour",proverbes.Afficher),
                new Menu("dicton du jour", dictons.Afficher),
                new Menu("Quitter", Quitter)
            };
        }
        static void AfficherMenu(IEnumerable<Menu> menu)
        {
            int indice = 0;

            foreach (var entree in menu)
            {
                indice++;
                Console.WriteLine($"{indice}. {entree.Titre}");
            }
        }
        static int LireChoix(int maxChoix)
        {
            int choix;
            bool choixOk;

            do
            {
                choixOk = Int32.TryParse(Console.ReadLine(), out choix) && 0 < choix && choix <= maxChoix;
            }
            while (!choixOk);
            return choix;
        }
    }
}
