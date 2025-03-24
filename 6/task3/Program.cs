using task3;

class Program
{
    static void Main(string[] args)
    {
        Instrument[] instruments = new Instrument[]
        {
            new Guitar("Fender"),
            new Drum("Bass"),
            new Guitar("Gibson"),
            new Drum("Snare")
        };

        Console.WriteLine("Струнные инструменты:");
        foreach (var instrument in instruments)
        {
            if (instrument is IStringInstrument stringInstrument)
            {
                stringInstrument.PluckStrings();
            }
        }
    }
}