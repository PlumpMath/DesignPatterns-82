using System.Collections.Generic;
namespace DesignPatterns.IteratorPattern.Agregate
{
    public class Facebook : DesignPatterns.IteratorPattern.Agregate.ISocialNetworking
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

        public DesignPatterns.IteratorPattern.Iterator.IIterator CreateIterater()
        {
            return new DesignPatterns.IteratorPattern.Iterator.FacebookIterator(Users);
        }

    }
}
