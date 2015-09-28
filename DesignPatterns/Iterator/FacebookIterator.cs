using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Iterator
{
    class FacebookIterator : IIterator
    {
        private LinkedList<string> Users;
        private int postion;
        public FacebookIterator(LinkedList<string> users)
        {
            Users = users;
            postion = 0;
        }
        void IIterator.First()
        {
            postion = 0;
        }

        string IIterator.Next()
        {
            return Users.ElementAt(postion++);
        }

        bool IIterator.IsDone()
        {
            return postion >= Users.Count();
        }

        string IIterator.CurrentItem()
        {
            return Users.ElementAt(postion);
        }
    }
}
