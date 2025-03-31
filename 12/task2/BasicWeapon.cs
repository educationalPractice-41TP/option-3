namespace task2
{
    public class BasicWeapon : IWeapon
    {
        public string GetDescription()
        {
            return "Базовое оружие";
        }

        public int GetDamage()
        {
            return 10; 
        }
    }
}
