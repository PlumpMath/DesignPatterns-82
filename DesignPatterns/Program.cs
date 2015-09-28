using DesignPatterns.Agregate;
using DesignPatterns.Iterator;
using DesignPatterns.Observer;
using DesignPatterns.Subject;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //StrategyandNull();

            //singleton();

            //observer();

            Iterater();

        }

        private static void Iterater()
        {
            ISocialNetworking fb = new Facebook();
            ISocialNetworking tw = new Twitter();
            IIterator fbIterator = fb.CreateIterater();
            IIterator twIterator = tw.CreateIterater();

            Console.WriteLine("Facebook Users");
            PrintUsers(fbIterator);
            Console.WriteLine("Twitter Users");
            PrintUsers(twIterator);
            Console.ReadKey();
        }

        private static void PrintUsers(IIterator Iterate)
        {
            Iterate.First();
            Console.WriteLine(Iterate.CurrentItem());
            while (!Iterate.IsDone())
            {
                Console.WriteLine(Iterate.Next());
            }
            Iterate.First();
            Console.WriteLine(Iterate.CurrentItem());
        }
        private static void StrategyandNull()
        {
            IWeapon weapon = null;
            Character ericHewett = new Character();
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Choose Eric's weapon");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        weapon = new Sword();
                        break;
                    case "1":
                        weapon = new Club();
                        break;
                    case "2":
                        weapon = new Axe();
                        break;
                    default:
                        weapon = new Null();
                        break;
                }
                ericHewett.setWeapon(weapon);
                ericHewett.Attack();
            }
        }

        private static void observer()
        {
            //Observer
            YoutubeChannel ericHewettChannel = new YoutubeChannel();
            ISubscriber jerry = new Moderator();
            ISubscriber bill = new User();
            ISubscriber ben = new User();

            ericHewettChannel.subscribe(jerry);
            ericHewettChannel.subscribe(bill);
            ericHewettChannel.subscribe(ben);

            ericHewettChannel.notifySubscriber();
            Console.ReadKey();
            ericHewettChannel.unsubscribe(bill);
            ericHewettChannel.notifySubscriber();
            Console.ReadKey();
        }

        private static void singleton()
        {
            //Singleton
            Logger logger = Logger.getInstance();
            logger.writeToFile("Hello");
            Console.ReadKey();
        }
    }
}
