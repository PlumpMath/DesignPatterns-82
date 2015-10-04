using DesignPatterns.FacadePattern.Concrete;
using System;
using DesignPatterns.FacadePattern.Facade;

namespace DesignPatterns.FacadePattern
{
    class FacadePattern : IDesignPattern
    {
        public void Run()
        {
            Client1();
            Client2();
        }
        public void Client1()
        {
            Dough Dough = new Dough();
            Sauce Sauce = new Sauce("Tomato");
            Topping Mushroom = new Topping("Mushrooms");
            Cheese Mozzarella = new Cheese("Mozzarella");
            PizzaFacade PizzaFacade = new Facade.PizzaFacade(Dough, Sauce, Mozzarella, Mushroom);
            PizzaFacade.MakePizza();
            Console.ReadKey();
        }
        public void Client2()
        {
            Dough Dough = new Dough();
            Sauce Sauce = new Sauce("Tomato");
            Topping Peppers = new Topping("Green Peppers");
            Cheese Mozzarella = new Cheese("Mozzarella");
            PizzaFacade PizzaFacade = new Facade.PizzaFacade(Dough, Sauce, Mozzarella, Peppers);
            PizzaFacade.MakePizza();
            Console.ReadKey();
        }
    }
}
