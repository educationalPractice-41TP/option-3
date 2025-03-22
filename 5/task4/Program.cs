public static class IntArrayExtensions
{
    public static int Sum(this int[] array)
    {
        int sum = 0;
        foreach (int number in array)
        {
            sum += number;
        }
        return sum;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        int totalSum = numbers.Sum();

        Console.WriteLine("Сумма элементов массива: " + totalSum);
    }
}
