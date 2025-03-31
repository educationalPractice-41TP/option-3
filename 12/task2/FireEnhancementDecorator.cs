namespace task2
{
    public class FireEnhancementDecorator : WeaponDecorator
    {
        public FireEnhancementDecorator(IWeapon weapon) : base(weapon) { }

        public override string GetDescription()
        {
            return _weapon.GetDescription() + " с огненной атакой";
        }

        public override int GetDamage()
        {
            return _weapon.GetDamage() + 5; // Увеличиваем урон на 5
        }
    }
}
