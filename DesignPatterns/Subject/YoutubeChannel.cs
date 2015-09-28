using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Observer;

namespace DesignPatterns.Subject
{
    class YoutubeChannel
    {
        private List<ISubscriber> Subscribers = new List<ISubscriber>();
        public void subscribe(ISubscriber s)
        {
            Subscribers.Add(s);
        }
        public void unsubscribe(ISubscriber s)
        {
            Subscribers.Remove(s);
        }
        public void notifySubscriber()
        {
            foreach(ISubscriber s in Subscribers)
            {
                s.Notify();
            }
        }
    }
}
