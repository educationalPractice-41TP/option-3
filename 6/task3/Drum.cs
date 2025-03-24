namespace task3
{
    public class Drum : Instrument, IPercussionInstrument
    {
        public Drum(string name) : base(name) { }

        public override void Play()
        {
            Hit();
        }

        public void Hit()
        {
            Console.WriteLine($"Бьём в барабан {Name}.");
        }
    }
}
