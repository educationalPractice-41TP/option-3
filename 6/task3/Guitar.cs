namespace task3
{
    public class Guitar : Instrument, IStringInstrument
    {
        public Guitar(string name) : base(name) { }

        public override void Play()
        {
            PluckStrings();
        }

        public void PluckStrings()
        {
            Console.WriteLine($"Игра на гитаре {Name}");
        }
    }
}
