namespace task2._2
{
    public class CharacterDirector
    {
        private ICharacterBuilder _builder;

        public CharacterDirector(ICharacterBuilder builder)
        {
            _builder = builder;
        }

        public Character CreateCharacter(string name)
        {
            _builder.SetName(name);
            return _builder.Build();
        }
    }
}
