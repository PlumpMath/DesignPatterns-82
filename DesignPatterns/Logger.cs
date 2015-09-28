using System;
namespace DesignPatterns
{
    //Singleton Class
    public class Logger
    {
        private static Logger logger = null;
        //private creator prevents instanciation
        private Logger() { }

        public static Logger getInstance()
        {
            if (logger == null)
            {
                logger = new Logger();
            }
            return logger;
        }

        public void writeToFile(string message)
        {
            Console.WriteLine("Write to file!"+message);
        }
    }
}
