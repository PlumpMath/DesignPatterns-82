using System;

namespace DesignPatterns.StrategyPattern
{
    class Null : DesignPatterns.StrategyPattern.IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Does nothing");
        }
    }
}
