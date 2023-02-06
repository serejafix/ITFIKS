namespace DZ_3.Task2
{
    public class Warrior
    {
        IWeapon weapon;
        public Warrior(IWeapon iweapon)
        {
            this.weapon = iweapon;
        }

        public string Print() => weapon.Kill();

    }
}
