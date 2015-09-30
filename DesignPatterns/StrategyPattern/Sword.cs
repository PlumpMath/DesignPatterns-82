using System;

namespace DesignPatterns.StrategyPattern
{
    class Sword:DesignPatterns.StrategyPattern.IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Use sword");
        }
    }
}
