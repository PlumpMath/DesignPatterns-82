using System;

namespace DesignPatterns.StrategyPattern
{
    public class StrategyPattern:IDesignPattern
    {
        public void Run()
        {
            DesignPatterns.StrategyPattern.IWeapon weapon = null;
            DesignPatterns.StrategyPattern.Character ericHewett = new DesignPatterns.StrategyPattern.Character();
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Choose Eric's weapon");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        weapon = new DesignPatterns.StrategyPattern.Sword();
                        break;
                    case "1":
                        weapon = new DesignPatterns.StrategyPattern.Club();
                        break;
                    case "2":
                        weapon = new DesignPatterns.StrategyPattern.Axe();
                        break;
                    default:
                        weapon = new DesignPatterns.StrategyPattern.Null();
                        break;
                }
                ericHewett.setWeapon(weapon);
                ericHewett.Attack();
            }
        }

    }
}
