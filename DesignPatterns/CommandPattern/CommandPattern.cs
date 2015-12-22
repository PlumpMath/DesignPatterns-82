using DesignPatterns.CommandPattern.ConcreteCommand;
using DesignPatterns.CommandPattern.Receiver;
using DesignPatterns.CommandPattern.Invoker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    public class CommandPattern : IDesignPattern
    {
        public void Run()
        {
            //Existing Stuff in house
            Light BedroomLights = new Light();
            AirConditioner AC = new AirConditioner();

            //Prepare Commands
            LightsOn TurnBedroomLightOn = new LightsOn(BedroomLights);
            AirConOn TurnAirConOn = new AirConOn(AC);

            LightsOff TurnBedRoomLightOff = new LightsOff(BedroomLights);
            AirConOff TurnAirConOff = new AirConOff(AC);

            //Controller

            RemoteControl RemoteControl = new RemoteControl();
            RemoteControl.InsertNewCommandOn(TurnBedroomLightOn);
            RemoteControl.InsertNewCommandOn(TurnAirConOn);
            RemoteControl.InsertNewCommandOff(TurnBedRoomLightOff);
            RemoteControl.InsertNewCommandOff(TurnAirConOff);

            //Test
            RemoteControl.TurnOn(0);
            RemoteControl.TurnOn(1);
            RemoteControl.TurnOff(0);
            RemoteControl.TurnOff(1);

        }
    }
}
