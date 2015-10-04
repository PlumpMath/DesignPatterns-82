
namespace DesignPatterns.FacadePattern.Concrete
{
    public class Topping
    {
        private string Name;
        public Topping(string name)
        {
            Name = name;
        }
        public string DescribeTopping()
        {
            return Name;
        }
    }
}
