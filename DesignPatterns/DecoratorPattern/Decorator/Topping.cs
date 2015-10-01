//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using DesignPatterns.DecoratorPattern.Component;
namespace DesignPatterns.DecoratorPattern.Decorator
{
    public abstract class Topping : DesignPatterns.DecoratorPattern.Component.Icecream
    {
        protected Icecream Icecream { set; get; }
        protected Topping(Icecream s)
        {
            Icecream = s;
        }
    }
}
