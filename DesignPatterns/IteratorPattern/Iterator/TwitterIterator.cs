
using System;
namespace DesignPatterns.IteratorPattern.Iterator
{
    class TwitterIterator : DesignPatterns.IteratorPattern.Iterator.IIterator
    {
        private string[] Users;
        private int postion;
        public TwitterIterator(string[] users)
        {
            Users = users;
            postion = 0;
        }
        void DesignPatterns.IteratorPattern.Iterator.IIterator.First()
        {
            postion = 0;
        }

        string DesignPatterns.IteratorPattern.Iterator.IIterator.Next()
        {
            return Users[postion++];
        }

        bool DesignPatterns.IteratorPattern.Iterator.IIterator.IsDone()
        {
            return postion >= Users.Length;
        }

        string DesignPatterns.IteratorPattern.Iterator.IIterator.CurrentItem()
        {
            return Users[postion];
        }
    }
}
