using task3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите два целых числа A и B (A < B):");

        Console.Write("A: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("B: ");
        int b = Convert.ToInt32(Console.ReadLine());

        if (a < b && a >= 1 && b <= 100)
        {
            NumberRange range = new NumberRange(a, b);
            range.DisplayNumbers();
        }
        else
        {
            Console.WriteLine("Ошибка: Убедитесь, что A < B и 1 <= A, B <= 100.");
        }
    }
}