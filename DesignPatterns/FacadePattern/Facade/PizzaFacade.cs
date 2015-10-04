using DesignPatterns.FacadePattern.Concrete;

namespace DesignPatterns.FacadePattern.Facade
{
    public class PizzaFacade
    {
        // Middle Man Pattern
        private Dough Dough;
        private Sauce Sauce;
        private Topping Topping;
        private Cheese Cheese;
        private Oven Oven = new Oven();
        public PizzaFacade(Dough dough, Sauce sauce, Cheese cheese, Topping topping)
        {
            this.Dough = dough;
            this.Sauce = sauce;
            this.Cheese = cheese;
            this.Topping = topping;
        }
        public void MakePizza()
        {
            Dough.AddSauce(Sauce);
            Dough.AddCheese(Cheese);
            Dough.AddTopping(Topping);
            Oven.SetTemperature(425);
            Oven.SetTimer(10);
            Oven.Cook(Dough);
            System.Console.WriteLine("Made Pizza with :" + Topping.DescribeTopping());
        }
    }
}
