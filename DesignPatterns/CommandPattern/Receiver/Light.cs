using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.Receiver
{
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Turn On Lights");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turn Off Lights");
        }
    }
}
