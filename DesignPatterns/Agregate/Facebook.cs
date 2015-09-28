using DesignPatterns.Iterator;
using System.Collections.Generic;
namespace DesignPatterns.Agregate
{
    public class Facebook : ISocialNetworking
    {
        private LinkedList<string> Users;
        public Facebook()
        {
            Users = new LinkedList<string>();
            Users.AddLast("Eric");
            Users.AddLast("Tom");
            Users.AddLast("Alasdair");
            Users.AddLast("Ray");
        }

        public IIterator CreateIterater()
        {
            return new FacebookIterator(Users);
        }

    }
}
