using DesignPatterns.ObserverPattern.Observer;
using DesignPatterns.ObserverPattern.Subject;
using System;
namespace DesignPatterns.ObserverPattern
{
    class ObserverPattern:IDesignPattern
    {
        public void Run()
        {
            //Observer
            YoutubeChannel ericHewettChannel = new YoutubeChannel();
            ISubscriber jerry = new Moderator();
            Observer.ISubscriber bill = new User();
            Observer.ISubscriber ben = new User();

            ericHewettChannel.subscribe(jerry);
            ericHewettChannel.subscribe(bill);
            ericHewettChannel.subscribe(ben);

            ericHewettChannel.notifySubscriber();
            Console.ReadKey();
            ericHewettChannel.unsubscribe(bill);
            ericHewettChannel.notifySubscriber();
            Console.ReadKey();
        }

    }
}
