using DesignPatterns.CommandPattern.AbstractCommand;
using DesignPatterns.CommandPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.ConcreteCommand
{
    public class AirConOn:ICommand
    {
        AirConditioner AirConditioner;
        public AirConOn(AirConditioner airConditioner)
        {
            this.AirConditioner = airConditioner;
        }

        public void Execute()
        {
            AirConditioner.TurnOn();
            AirConditioner.IncreaseTemp();
        }
    }
}
