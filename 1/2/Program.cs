using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите трёхзначное число:");
        int number = Convert.ToInt32(Console.ReadLine());

        int firstDigit = number / 100;
        int lastDigit = number % 10;

        Console.WriteLine($"Первая цифра: {firstDigit}");
        Console.WriteLine($"Последняя цифра: {lastDigit}");
    }
}