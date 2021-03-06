﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StateDesignPattern
{
    public class StateContext
    {
        private IStateMode myState;
        public StateContext()
        {
            setState(new StateLowerCase());
        }

        /**
         * Setter method for the state.
         * Normally only called by classes implementing the State interface.
         * @param newState the new state of this context
         */
        public void setState(IStateMode newState)
        {
            myState = newState;
        }

        public void writeName(string name)
        {
            myState.writeName(this, name);
        }
    }
}
