using DesignPatterns.Iterator;

namespace DesignPatterns.Agregate
{
    public class Twitter : ISocialNetworking
    {
        private string[] Users;
        public Twitter()
        {
            Users = new[] { "Mhairi", "Emmilie", "Bronwen", "Ray" };
        }
        public IIterator CreateIterater()
        {
            return new TwitterIterator(Users);
        }
    }
}
