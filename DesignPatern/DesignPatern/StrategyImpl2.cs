using System;
using System.Collections.Generic;
using System.Text;

namespace PaternStrategy
{
    public class StrategyImpl2 : IStrategy
    {
        public void applyStategy()
        {
            Console.WriteLine("Etape  intermediaire de l'algo avec la strategi 2");
        }
    }
}
