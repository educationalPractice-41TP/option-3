using task1;

public class Program
{
    public static void Main(string[] args)
    {
        CharacterFactory mageFactory = new MageFactory();
        ICharacter mage = mageFactory.CreateCharacter();
        mage.Attack();

        CharacterFactory warriorFactory = new WarriorFactory();
        ICharacter warrior = warriorFactory.CreateCharacter();
        warrior.Attack();

        CharacterFactory archerFactory = new ArcherFactory();
        ICharacter archer = archerFactory.CreateCharacter();
        archer.Attack();
    }
}