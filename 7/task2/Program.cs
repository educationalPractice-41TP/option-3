public delegate bool NumberCheck(int number);

class Program
{
    public static void FilterNumbers(int[] numbers, NumberCheck check)
    {
        foreach (var number in numbers)
        {
            if (check(number))
            {
                Console.WriteLine(number);
            }
        }
    }

    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public static bool IsOdd(int number)
    {
        return number % 2 != 0;
    }

    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Четные числа:");
        FilterNumbers(numbers, IsEven);

        Console.WriteLine("Нечетные числа:");
        FilterNumbers(numbers, IsOdd);
    }
}
