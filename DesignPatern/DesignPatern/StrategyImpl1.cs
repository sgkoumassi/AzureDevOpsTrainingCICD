using System;
using System.Collections.Generic;
using System.Text;

namespace PaternStrategy
{
    public class StrategyImpl1 : IStrategy
    {
        public void applyStategy()
        {
            Console.WriteLine("Etape intermediaire de l'algo avec la strategy 1");
        }
    }
}
