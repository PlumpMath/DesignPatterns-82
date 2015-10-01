//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


namespace DesignPatterns.DecoratorPattern.ConcreteComponent
{
    public class Vanilla : DesignPatterns.DecoratorPattern.Component.Icecream
    {
        public override double Cost()
        {
            return 1.75;
        }
    }
}
