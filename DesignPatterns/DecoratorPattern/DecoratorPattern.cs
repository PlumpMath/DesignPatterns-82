
using DesignPatterns.DecoratorPattern.Component;
using DesignPatterns.DecoratorPattern.ConcreteComponent;
using DesignPatterns.DecoratorPattern.ConcreteDecorator;
using System;
namespace DesignPatterns.DecoratorPattern
{
    public class DecoratorPattern : IDesignPattern
    {
        public void Run()
        {
            Icecream iceCream = new Chocolate();
            iceCream = new Fudge(iceCream);
            iceCream = new Sprinkle(iceCream);
            Console.WriteLine("Cost of Icecream: " + iceCream.Cost().ToString());
            Console.ReadKey();
        }
    }
}
