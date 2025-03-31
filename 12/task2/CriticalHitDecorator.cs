namespace task2
{
    public class CriticalHitDecorator : WeaponDecorator
    {
        public CriticalHitDecorator(IWeapon weapon) : base(weapon) { }

        public override string GetDescription()
        {
            return _weapon.GetDescription() + " с шансом критического удара";
        }

        public override int GetDamage()
        {
            // Увеличиваем урон на 50% для критического удара
            return (int)(_weapon.GetDamage() * 1.5);
        }
    }
}
