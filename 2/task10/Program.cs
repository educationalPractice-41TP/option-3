using task10;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число n:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите цифру k (0-9):");
        int k = Convert.ToInt32(Console.ReadLine());

        if (k < 0 || k > 9)
        {
            Console.WriteLine("Ошибка: k должно быть цифрой от 0 до 9.");
            return;
        }

        DigitCounter digitCounter = new DigitCounter(n, k);
        int occurrences = digitCounter.CountDigitOccurrences();

        Console.WriteLine($"Цифра {k} встречается в числе {n} {occurrences} раз(а).");
    }
}