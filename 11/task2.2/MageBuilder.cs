namespace task2._2
{
    public class MageBuilder : ICharacterBuilder
    {
        private Character _character = new Character();

        public void SetName(string name)
        {
            _character.Name = name;
            _character.Class = "Маг";
            _character.Health = 100;
            _character.Mana = 100;
            _character.AttackPower = 30;
        }

        public void SetHealth(int health) { _character.Health = health; }
        public void SetMana(int mana) { _character.Mana = mana; }
        public void SetAttackPower(int attackPower) { _character.AttackPower = attackPower; }

        public Character Build()
        {
            return _character;
        }
    }
}
