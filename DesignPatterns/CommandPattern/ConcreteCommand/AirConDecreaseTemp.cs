using DesignPatterns.CommandPattern.AbstractCommand;
using DesignPatterns.CommandPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.ConcreteCommand
{
    class AirConDecreaseTemp : ICommand
    {
        AirConditioner AirConditioner;
        public AirConDecreaseTemp(AirConditioner airConditioner)
        {
            this.AirConditioner = airConditioner;
        }

        public void Execute()
        {
            AirConditioner.DecreaseTemp();
        }
    }
}
