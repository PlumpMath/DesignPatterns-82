using DesignPatterns.CommandPattern.AbstractCommand;
using DesignPatterns.CommandPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.ConcreteCommand
{
    public class LightsOn:ICommand
    {
        Light Light;
        public LightsOn(Light light)
        {
            this.Light = light;
        }

        public void Execute()
        {
            Light.TurnOn();
        }
    }
}
