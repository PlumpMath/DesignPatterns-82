using System;
namespace DesignPatterns.ObserverPattern.Observer
{
    class Moderator : DesignPatterns.ObserverPattern.Observer.ISubscriber
    {
        public void Notify()
        {
            Console.WriteLine("Moderator notified of new video!");
        }
    }
}
