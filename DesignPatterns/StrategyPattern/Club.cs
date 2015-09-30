using System;

namespace DesignPatterns.StrategyPattern
{
    class Club : DesignPatterns.StrategyPattern.IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Use Club");
        }
    }
}
