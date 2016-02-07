using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StateDesignPattern
{
    public class StateMultipleUpperCase : IStateMode
    {
        /** Counter local to this state */
        private int count = 0;
        public void writeName(StateContext context, string name)
        {
            System.Console.WriteLine(name.ToUpper());
            /* Change state after StateMultipleUpperCase's writeName() gets invoked twice */
            if (++count > 1)
            {
                context.setState(new StateLowerCase());
            }
        }
    }
}
