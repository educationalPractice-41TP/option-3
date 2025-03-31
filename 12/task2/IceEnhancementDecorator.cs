namespace task2
{
    public class IceEnhancementDecorator : WeaponDecorator
    {
        public IceEnhancementDecorator(IWeapon weapon) : base(weapon) { }

        public override string GetDescription()
        {
            return _weapon.GetDescription() + " с ледяной атакой";
        }

        public override int GetDamage()
        {
            return _weapon.GetDamage() + 3; // Увеличиваем урон на 3
        }
    }
}
