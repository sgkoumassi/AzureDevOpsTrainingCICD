using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class RectangleRond : IForme
    {
        public void dessiner()
        {
            Console.WriteLine("Je suis dans la méthode dessiner de la classe Rectangle avec des motifs ronds ");
        }
    }
}
