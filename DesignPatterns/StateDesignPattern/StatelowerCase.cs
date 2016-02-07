using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StateDesignPattern
{
    public class StateLowerCase: IStateMode
    {
        public void writeName( StateContext context, string name)
        {
            System.Console.WriteLine(name.ToLower());
            context.setState(new StateMultipleUpperCase());
        }
    }
}
