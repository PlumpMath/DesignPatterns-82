using System;

namespace DesignPatterns.SingletonPattern
{
    public class SingletonPattern :IDesignPattern
    {
        public void Run()
        {
            //Singleton
            DesignPatterns.SingletonPattern.Logger logger = DesignPatterns.SingletonPattern.Logger.getInstance();
            logger.writeToFile("Hello");
            Console.ReadKey();
        }
    }
}
