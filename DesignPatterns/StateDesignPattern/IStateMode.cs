using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StateDesignPattern
{
    public interface IStateMode
    {
        void writeName(StateContext context, string name);
    }
}
