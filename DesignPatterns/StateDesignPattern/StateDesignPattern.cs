using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StateDesignPattern
{
    public class StateDesignPattern : IDesignPattern
    {
        public void Run()
        {
            StateContext sc = new StateContext();

            sc.writeName("Monday");
            sc.writeName("Tuesday");
            sc.writeName("Wednesday");
            sc.writeName("Thursday");
            sc.writeName("Friday");
            sc.writeName("Saturday");
            sc.writeName("Sunday");
        }
    }
}
