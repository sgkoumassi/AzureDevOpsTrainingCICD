using System;
using System.Collections.Generic;
using System.Text;

namespace PatternFactoryMethod
{
    public class Rectangle: IForme
    {
        public void dessiner()
        {
            Console.WriteLine("Je suis dans la méthode dessiner de la classe Rectangle ");
        }
    }
}
