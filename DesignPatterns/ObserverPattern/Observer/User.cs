using System;
namespace DesignPatterns.ObserverPattern.Observer
{
    class User : DesignPatterns.ObserverPattern.Observer.ISubscriber
    {
        public void Notify()
        {
            Console.WriteLine("User watches video");
        }
    }
}
