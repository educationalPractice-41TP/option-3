using task5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число:");

        int number = Convert.ToInt32(Console.ReadLine());

        OddChecker checker = new OddChecker(number);
        bool isOdd = checker.IsOdd();

        if (isOdd)
        {
            Console.WriteLine($"{number} является нечетным числом.");
        }
        else
        {
            Console.WriteLine($"{number} является четным числом.");
        }
    }
}