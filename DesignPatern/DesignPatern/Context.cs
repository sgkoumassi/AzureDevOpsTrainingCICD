using System;
using System.Collections.Generic;
using System.Text;

namespace PaternStrategy
{
   public class Context
    {
       private IStrategy strategy;
       public Context()
        {
            this.strategy = new DefaultStrategyImpl();
        }
        public void process()
        {
            Console.WriteLine("Etape1 de l'algo !");
            strategy.applyStategy();
            Console.WriteLine("Etape finale de l'algo !");
        }
    public void SetStrategy(IStrategy strategy) {
            this.strategy = strategy;
        }
    }
}
