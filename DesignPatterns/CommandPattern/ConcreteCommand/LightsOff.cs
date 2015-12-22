using DesignPatterns.CommandPattern.AbstractCommand;
using DesignPatterns.CommandPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.ConcreteCommand
{
    public class LightsOff:ICommand
    {
        Light Light;
        public LightsOff(Light light)
        {
            this.Light = light;
        }

        public void Execute()
        {
            Light.TurnOff();
        }
    }
}
