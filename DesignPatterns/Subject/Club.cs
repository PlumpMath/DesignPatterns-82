using System;

namespace DesignPatterns.Subject
{
    class Club : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Use Club");
        }
    }
}
