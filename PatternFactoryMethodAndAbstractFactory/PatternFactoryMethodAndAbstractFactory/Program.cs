using System;

namespace PatternFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FabriqueDeForme fabriqueDeForme = new FabriqueDeForme();

            // Creation d'un objet cercle et sa methode dessiner
            IForme formeCercle = fabriqueDeForme.getForme("cercle");
            formeCercle.dessiner();

            // Creation d'un objet caree et sa methode dessiner
            IForme formeCaree = fabriqueDeForme.getForme("caree");
            formeCaree.dessiner();

            // Creation d'un objet rectangle et sa methode dessiner
            IForme formeRectangle = fabriqueDeForme.getForme("rectangle");
            formeRectangle.dessiner();

            Console.ReadKey();
         
        }
    }
}
