using System;

namespace DesignPatterns.StrategyPattern
{
    public class Axe : DesignPatterns.StrategyPattern.IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Use Axe");
        }
    }
}
