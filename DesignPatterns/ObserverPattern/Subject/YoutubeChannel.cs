using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPatterns.ObserverPattern.Subject
{
    class YoutubeChannel
    {
        private List<DesignPatterns.ObserverPattern.Observer.ISubscriber> Subscribers = new List<DesignPatterns.ObserverPattern.Observer.ISubscriber>();
        public void subscribe(DesignPatterns.ObserverPattern.Observer.ISubscriber s)
        {
            Subscribers.Add(s);
        }
        public void unsubscribe(DesignPatterns.ObserverPattern.Observer.ISubscriber s)
        {
            Subscribers.Remove(s);
        }
        public void notifySubscriber()
        {
            foreach(DesignPatterns.ObserverPattern.Observer.ISubscriber s in Subscribers)
            {
                s.Notify();
            }
        }
    }
}
