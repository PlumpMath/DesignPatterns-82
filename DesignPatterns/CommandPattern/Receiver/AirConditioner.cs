using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.Receiver
{
    public class AirConditioner
    {
        public void TurnOn()
        {
            Console.WriteLine("Turn On AirConditioner");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turn Off AirConditioner");
        }

        public void IncreaseTemp()
        {
            Console.WriteLine("Increase Temp");
        }

        public void DecreaseTemp()
        {
            Console.WriteLine("Decrease Temp");
        }
    }
}

