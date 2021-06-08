using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactorielleTDD.Test
{
    [TestClass]
    public class Math
    {
        [TestInitialize]
        public void InitialisationDesTests()
        {
            // rajouter les initialisations
        }

        [TestMethod]
        public static int Factorielle(int a)
        {
            if (a <= 1)
                return 1;
            return a * Factorielle(a - 1);
        }

        [TestMethod]
        public void Factorielle_AvecValeur3_Retourne6()
        {
            int val = 3;
            int result = Factorielle(val);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Factorielle_AvecValeur10_Retourne1()
        {
            int valeur = 10;
            int resultat = Math.Factorielle(valeur);
            Assert.AreEqual(1, resultat, "La valeur doit être égale à 1");
        }

        [TestCleanup]
        public void NettoyageDesTests()
        {
            // nettoyer les variables, ...
        }
    }
}
