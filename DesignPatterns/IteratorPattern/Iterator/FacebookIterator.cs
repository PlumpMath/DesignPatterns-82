using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.IteratorPattern.Iterator
{
    class FacebookIterator : DesignPatterns.IteratorPattern.Iterator.IIterator
    {
        private LinkedList<string> Users;
        private int postion;
        public FacebookIterator(LinkedList<string> users)
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
            return Users.ElementAt(postion++);
        }

        bool DesignPatterns.IteratorPattern.Iterator.IIterator.IsDone()
        {
            return postion >= Users.Count();
        }

        string DesignPatterns.IteratorPattern.Iterator.IIterator.CurrentItem()
        {
            return Users.ElementAt(postion);
        }
    }
}
