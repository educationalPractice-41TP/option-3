namespace task2
{
    public abstract class WeaponDecorator : IWeapon
    {
        protected IWeapon _weapon;

        protected WeaponDecorator(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public abstract string GetDescription();
        public abstract int GetDamage();
    }
}
