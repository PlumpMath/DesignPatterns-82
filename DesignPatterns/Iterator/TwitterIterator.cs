
using System;
namespace DesignPatterns.Iterator
{
    class TwitterIterator : IIterator
    {
        private string[] Users;
        private int postion;
        public TwitterIterator(string[] users)
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
            return Users[postion++];
        }

        bool IIterator.IsDone()
        {
            return postion >= Users.Length;
        }

        string IIterator.CurrentItem()
        {
            return Users[postion];
        }
    }
}
