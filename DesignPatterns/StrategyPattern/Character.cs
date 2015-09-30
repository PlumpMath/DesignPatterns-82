
namespace DesignPatterns.StrategyPattern
{
    class Character
    {
        private DesignPatterns.StrategyPattern.IWeapon Weapon;
        public void setWeapon(DesignPatterns.StrategyPattern.IWeapon weapon)
        {
            Weapon = weapon;
        }
        public void Attack()
        {
            Weapon.Use();
        }
    }
}
