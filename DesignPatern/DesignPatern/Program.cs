using System;

namespace PaternStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.process();
            Console.WriteLine("----------------------------");

            context.SetStrategy(new StrategyImpl1());
            context.process();
            Console.WriteLine("----------------------------");

            context.SetStrategy(new StrategyImpl2());
            context.process();
            Console.WriteLine("----------------------------");

            context.SetStrategy(new StrategyImpl3());
            context.process();


            Console.ReadKey();
        }
    }
}
