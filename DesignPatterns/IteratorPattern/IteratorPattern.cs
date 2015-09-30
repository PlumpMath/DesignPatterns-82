using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorPattern
{
    public class IteratorPattern:IDesignPattern
    {
        public void Run()
        {
            DesignPatterns.IteratorPattern.Agregate.ISocialNetworking fb = new DesignPatterns.IteratorPattern.Agregate.Facebook();
            DesignPatterns.IteratorPattern.Agregate.ISocialNetworking tw = new DesignPatterns.IteratorPattern.Agregate.Twitter();
            DesignPatterns.IteratorPattern.Iterator.IIterator fbIterator = fb.CreateIterater();
            DesignPatterns.IteratorPattern.Iterator.IIterator twIterator = tw.CreateIterater();

            Console.WriteLine("Facebook Users");
            PrintUsers(fbIterator);
            Console.WriteLine("Twitter Users");
            PrintUsers(twIterator);
            Console.ReadKey();
        }

        private static void PrintUsers(DesignPatterns.IteratorPattern.Iterator.IIterator Iterate)
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
    }
}
