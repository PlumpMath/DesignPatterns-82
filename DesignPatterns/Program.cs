

using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IDesignPattern DesignPattern = null;

            Console.WriteLine("Strategy and Null");
            DesignPattern = new StrategyPattern.StrategyPattern();
            DesignPattern.Run();

            Console.WriteLine("Singleton");
            DesignPattern = new SingletonPattern.SingletonPattern();
            DesignPattern.Run();

            Console.WriteLine("Observer");
            DesignPattern = new ObserverPattern.ObserverPattern();
            DesignPattern.Run();

            Console.WriteLine("Iterator");
            DesignPattern = new IteratorPattern.IteratorPattern();
            DesignPattern.Run();

            Console.WriteLine("Design Pattern");
            DesignPattern = new DecoratorPattern.DecoratorPattern();
            DesignPattern.Run();
        }
    }
}
