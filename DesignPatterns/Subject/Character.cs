
namespace DesignPatterns.Subject
{
    class Character
    {
        private IWeapon Weapon;
        public void setWeapon(IWeapon weapon)
        {
            Weapon = weapon;
        }
        public void Attack()
        {
            Weapon.Use();
        }
    }
}
