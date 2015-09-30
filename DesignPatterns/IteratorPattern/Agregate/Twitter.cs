
namespace DesignPatterns.IteratorPattern.Agregate
{
    public class Twitter : DesignPatterns.IteratorPattern.Agregate.ISocialNetworking
    {
        private string[] Users;
        public Twitter()
        {
            Users = new[] { "Mhairi", "Emmilie", "Bronwen", "Ray" };
        }
        public DesignPatterns.IteratorPattern.Iterator.IIterator CreateIterater()
        {
            return new DesignPatterns.IteratorPattern.Iterator.TwitterIterator(Users);
        }
    }
}
