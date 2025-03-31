namespace task1
{
    public class MageFactory : CharacterFactory
    {
        public override ICharacter CreateCharacter()
        {
            return new Mage();
        }
    }

    public class WarriorFactory : CharacterFactory
    {
        public override ICharacter CreateCharacter()
        {
            return new Warrior();
        }
    }

    public class ArcherFactory : CharacterFactory
    {
        public override ICharacter CreateCharacter()
        {
            return new Archer();
        }
    }
}
