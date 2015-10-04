
namespace DesignPatterns.FacadePattern.Concrete
{
    public class Dough
    {
        private Cheese Cheese;
        private Topping Topping;
        private Sauce Sauce;
        public void AddCheese(Cheese cheese)
        {
            Cheese = cheese;
        }
        public void AddTopping(Topping topping)
        {
            Topping = topping;
        }
        public void AddSauce(Sauce sauce)
        {
            Sauce = sauce;
        }
    }
}
