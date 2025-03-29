namespace task2._2
{
    public interface ICharacterBuilder
    {
        void SetName(string name);
        void SetHealth(int health);
        void SetMana(int mana);
        void SetAttackPower(int attackPower);
        Character Build();
    }
}
