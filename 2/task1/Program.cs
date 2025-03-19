using task1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите массу в килограммах:");
        double kilograms = Convert.ToDouble(Console.ReadLine());

        WeightConverter converter = new WeightConverter(kilograms);
        int fullTons = converter.GetFullTons();

        Console.WriteLine($"Количество полных тонн: {fullTons}");
    }
}