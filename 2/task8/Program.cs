using task8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число N (N > 0):");
        int N = Convert.ToInt32(Console.ReadLine());

        if (N <= 0)
        {
            Console.WriteLine("Ошибка: N должно быть больше 0.");
            return;
        }

        SquareCalculator calculator = new SquareCalculator(N);
        calculator.CalculateAndPrintSquares();
    }
}