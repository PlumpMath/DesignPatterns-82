using DesignPatterns.CommandPattern.AbstractCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.Invoker
{
    public class RemoteControl
    {
        private List<ICommand> turnCommandsOn = new List<ICommand>();
        private List<ICommand> turnCommandsOff = new List<ICommand>();

        public void InsertNewCommandOn(ICommand command)
        {
            turnCommandsOn.Add(command);
        }

        public void InsertNewCommandOff(ICommand command)
        {
            turnCommandsOff.Add(command);
        }

        public void TurnOn(int buttonNo)
        {
            turnCommandsOn[buttonNo].Execute();
        }
        public void TurnOff(int buttonNo)
        {
            turnCommandsOff[buttonNo].Execute();
        }

    }
}
