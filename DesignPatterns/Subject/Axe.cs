using System;

namespace DesignPatterns.Subject
{
    public class Axe : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Use Axe");
        }
    }
}
