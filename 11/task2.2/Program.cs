using task2._2;

class Program
{
    static void Main(string[] args)
    {
        ICharacterBuilder mageBuilder = new MageBuilder();
        CharacterDirector mageDirector = new CharacterDirector(mageBuilder);
        Character mage = mageDirector.CreateCharacter("Гендальф");
        Console.WriteLine(mage);
    }
}