namespace task2._2
{
    public class Character
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int AttackPower { get; set; }

        public override string ToString()
        {
            return $"{Name} - Класс: {Class}, ХП: {Health}, МП: {Mana}, АП: {AttackPower}";
        }
    }
}
