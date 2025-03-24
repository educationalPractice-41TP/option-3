namespace task3
{
    public abstract class Instrument
    {
        public string Name { get; }

        protected Instrument(string name)
        {
            Name = name;
        }

        public abstract void Play();
    }
}
