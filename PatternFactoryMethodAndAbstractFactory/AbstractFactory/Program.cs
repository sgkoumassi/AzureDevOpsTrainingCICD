using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            // creation de la forme factory
            FabriqueDeFormeAbstraite fabriqueDeForme = ProducteurDeFabrique.getFabrique(false);

            // creation de la forme rectangle et Appele de la methode dessiner
            IForme formeRectangle = fabriqueDeForme.getForme("rectangle");
            formeRectangle.dessiner();
            // creation de la forme caree et Appele de la methode dessiner
            IForme formeCaree = fabriqueDeForme.getForme("caree");
            formeCaree.dessiner();

            // creation de la forme factory
            FabriqueDeFormeAbstraite fabriqueDeFormeRond = ProducteurDeFabrique.getFabrique(true);

            // creation de la forme rectangle avec le motif rond et Appele de la methode dessiner
            IForme formeRectangleRond = fabriqueDeFormeRond.getForme("rectangle");
            formeRectangleRond.dessiner();
            // creation de la forme rectangle avec le motif rond et Appele de la methode dessiner
            IForme formeCareeRond = fabriqueDeFormeRond.getForme("caree");
            formeCareeRond.dessiner();

            Console.ReadKey();
        }
    }
}
