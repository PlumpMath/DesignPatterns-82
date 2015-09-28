using System;

namespace DesignPatterns.Subject
{
    class Sword:IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Use sword");
        }
    }
}
