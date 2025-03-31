namespace task1
{
    public class Mage : ICharacter
    {
        public void Attack()
        {
            Console.WriteLine("Маг атакует заклинанием!");
        }
    }

    public class Warrior : ICharacter
    {
        public void Attack()
        {
            Console.WriteLine("Воин атакует мечом!");
        }
    }

    public class Archer : ICharacter
    {
        public void Attack()
        {
            Console.WriteLine("Лучник стреляет из лука!");
        }
    }
}
