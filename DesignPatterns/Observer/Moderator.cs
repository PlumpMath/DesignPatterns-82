using System;
namespace DesignPatterns.Observer
{
    class Moderator : ISubscriber
    {
        public void Notify()
        {
            Console.WriteLine("Moderator notified of new video!");
        }
    }
}
