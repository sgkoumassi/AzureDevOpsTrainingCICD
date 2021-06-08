using System;
using System.Collections.Generic;
using System.Text;

namespace PaternStrategy
{
    public class DefaultStrategyImpl : IStrategy
    {
        public void applyStategy()
        {
            Console.WriteLine("Etape  intermediaire de l'algo avec la strategi par defaut");
        }
    }
}
