using System;

namespace DesignPatterns.Subject
{
    class Null : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Does nothing");
        }
    }
}
