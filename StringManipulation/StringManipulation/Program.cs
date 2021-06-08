using System;
using System.Text;
using System.Text.RegularExpressions;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string str = "5 chiens, 3      chevaux, 40 chats   et 2 oiseaux.";
            string str2 ="This is text" ;
            string str3 = "Hello Soul, how are you doing today ?";
            string str4 = "THIS IS TEXT";

            #region String manipulation
            // Some methodes
            if (str.Contains("chiens"))
                Console.WriteLine("'Chiens' was found");

            if (String.Compare(str2, str4) == 0)
            {
                Console.WriteLine(str2 + " and " + str4 + " are equal.");
            }
            else
            {
                Console.WriteLine(str2 + " and " + str4 + " are not equal.");
            }
            // IndexOf
            int idxOfS = str2.IndexOf('s');
            int idxOdS2 = str2.IndexOf('s', 6);
            Console.WriteLine("- The first IndexOf('s') =" + idxOfS);
            Console.WriteLine("- The second IndexOf('s') =" + idxOdS2);

            
            // Remplacez la première sous-chaîne par une nouvelle sous-chaîne.
            static string ReplaceFirst(string text, string search, string replace)
            {
                int pos = text.IndexOf(search);
                if (pos < 0)
                {
                    return text;
                }
                return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
            }

            string str5 = ReplaceFirst(str2, "This", "None");
            Console.WriteLine("- str2 befor replacement =" + str2);
            Console.WriteLine("- str2 after replacement =" + str5);
            // Regex.Split
            // Suppression de plusieurs espaces vides
            string strToReplaced = Regex.Replace(str, "\\s+", " ");
           

            // Divition en fonction des espaces presente
            string[] listToSplit = Regex.Split(strToReplaced, @"\s+");

            string strJoin = String.Join("\n", listToSplit);

            //Division en foction des nombres
            string[] numbersInStr = Regex.Split(strToReplaced, @"\D+");
          

            Console.WriteLine("Original String: " + str);
            Console.WriteLine("Cleaned String: " + strToReplaced); 
            Console.WriteLine("Cleaned with join() method: " + strJoin);

            //Extraction et affichage des nobres
            foreach (string nbr in numbersInStr)
            {
                if (!int.TryParse(nbr, out _))
                {
                    continue;
                }
                Console.WriteLine(nbr);
            }
            // Affichage du contenu de listToSplit
            foreach (string item in listToSplit)
            {
                Console.WriteLine(item);
            }

            // Utilisation La methode Substring()
            //Extration à partir du 
            string souChaineOiseau = strToReplaced.Substring(34);
            string sousChaineChat = strToReplaced.Substring(23, 6);
            Console.WriteLine("La sous chaine Oiseau: " + souChaineOiseau);
            Console.WriteLine("La sous chaine Chat: " + sousChaineChat);
            #endregion

            #region StringBuider manipulation 

            StringBuilder phrase = new StringBuilder();
            phrase.Append(str3);
            Console.WriteLine("phrase befor append: " + phrase);

            phrase.Append(" Do you know what is StringBuider");
            Console.WriteLine("phrase after append: " + phrase);

            phrase.Insert(10, "eymane");
            Console.WriteLine("phrase after insertion: " + phrase);

            #endregion

           

            Console.ReadKey();
        }
    }
}
