
namespace DesignPatterns.FacadePattern.Concrete
{
    public class Oven
    {
        int Timer;
        int Temperature;
        Dough Dough;
        public void SetTimer(int timer)
        {
            Timer = timer;
        }
        public void SetTemperature(int temperature)
        {
            Temperature = temperature;
        }

        public void Cook(Dough dough)
        {
            Dough = dough;
        }
    }
}
