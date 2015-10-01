using DesignPatterns.DecoratorPattern.Component;
namespace DesignPatterns.DecoratorPattern.ConcreteDecorator
{
    public class Sprinkle : DesignPatterns.DecoratorPattern.Decorator.Topping
    {
        public Sprinkle(Icecream s)
            : base(s)
        { }

        public override double Cost()
        {
            return .2 + Icecream.Cost();
        }
    }
}
