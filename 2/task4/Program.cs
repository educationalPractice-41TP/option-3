using task4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение x:");

        double x = Convert.ToDouble(Console.ReadLine());

        Function calculator = new Function(x);
        double y = calculator.CalculateY();

        Console.WriteLine($"Значение функции y: {y}");
    }
}