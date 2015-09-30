using System;
namespace DesignPatterns.SingletonPattern
{
    //Singleton Class
    public class Logger
    {
        private static DesignPatterns.SingletonPattern.Logger logger = null;
        //private creator prevents instanciation
        private Logger() { }

        public static DesignPatterns.SingletonPattern.Logger getInstance()
        {
            if (logger == null)
            {
                logger = new DesignPatterns.SingletonPattern.Logger();
            }
            return logger;
        }

        public void writeToFile(string message)
        {
            Console.WriteLine("Write to file!"+message);
        }
    }
}
