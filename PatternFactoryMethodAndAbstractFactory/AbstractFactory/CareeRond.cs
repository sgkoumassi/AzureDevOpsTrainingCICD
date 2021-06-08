using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class CareeRond: IForme
    {
        public void dessiner()
        {
            Console.WriteLine("Je suis dans la méthode dessiner de la classe Carée avec des motifs ronds ");
        }
    }
}
