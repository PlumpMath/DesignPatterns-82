using System;
namespace DesignPatterns.Observer
{
    class User : ISubscriber
    {
        public void Notify()
        {
            Console.WriteLine("User watches video");
        }
    }
}
