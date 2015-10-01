
using  DesignPatterns.DecoratorPattern.Component;
namespace DesignPatterns.DecoratorPattern.ConcreteDecorator
{
    class Fudge : DesignPatterns.DecoratorPattern.Decorator.Topping
    {
        public Fudge(Icecream s):base(s)
        {

        }

        public override double Cost()
        {
            return .5 + Icecream.Cost();
        }
    }
}
