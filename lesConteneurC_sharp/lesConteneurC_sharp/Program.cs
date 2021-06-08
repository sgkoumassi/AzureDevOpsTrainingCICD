using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesConteneurC_sharp
{
    class Program
    {
        // Utilisation des linq avec une méthode personnalisée
        static bool EstAgreable(string meteo)
        {
            string [] conditions= { "Rain", "Snow", "Cold", "Wind" };
            return (conditions.Contains(meteo));
        }


        static void Main(string[] args)
        {
            

            var situation = new List<string>() { "Rain", "Snow", "Cold", "Wind" };
            // les expression lamda
            var lamda = situation.Find(x => x == "Cold");
            Console.WriteLine(" I found " + lamda);

            // Utilisation des linq avec une méthode personnalisée
            var result2 =
            from si in situation
                orderby si descending
                where EstAgreable(si)
                select si;

            foreach (string sit2 in result2)
            {
                Console.WriteLine(" I found by the LINQ méthodes with own reseach function: " + sit2);
            }

            //Linq + fonction anonyme
            var result3 =
            from si in situation
            orderby si descending
            where new [] { "Rain", "Snow", "Cold", "Wind" }.Contains(si)
            select si;

            foreach (string sit3 in result3)
            {
                Console.WriteLine(" I found by the LINQ méthodes with anonymous function: " + sit3);
            }

            // Linq avec la systaxe objet : utilisation des methodes d'extention

            var result4 = situation
                .Where(si => new[] { "Rain", "Snow", "Cold", "Wind" }.Contains(si))
                .OrderByDescending(si => si).ToList();
            Console.WriteLine(" I found by the LINQ méthodes with object extention methode : " + result4.Min());

            // les LINQ : Language Integrated Query
            var result =
            from si in situation
            //orderby si descending
            //where si == "Snow"
            //group si by si into si2
            //select si2.Min();
            select si;
            foreach (string sit in result)
            { 
                Console.WriteLine(" I found by the LINQ méthodes: " + sit );
            }
            // les types anonymes
            var rightnow = new { Saison = "summer", Meteo = "rain", temperature = "cold", Date = "Date.Now" };
            Console.WriteLine("There are " + rightnow.Saison);

            // les dictionnaires
            var situation2 = new Dictionary<string,int>() { { "pluie", 0 },{ "neige", 0 }, { "froid", 0 }, { "vent", 0 } };
            situation.Add("chaud");
            situation2.Add("chaud",1);
            situation2["pluie"] = 1;
            situation2["pluie"]++;

            foreach (string s in situation)
            {
                Console.WriteLine("Today it's " + s );
                
            }
            foreach(KeyValuePair<string,int> s1 in situation2)
            {
                Console.WriteLine("There are " + s1.Key + " " + s1.Value.ToString() + " times ");
            }
            Console.WriteLine(" It rain " + situation2["pluie"].ToString() + " times ");
            Console.WriteLine(situation.Count);

            Console.WriteLine(" Presse any key to exit !");
            Console.ReadLine();
        }
    }
}
