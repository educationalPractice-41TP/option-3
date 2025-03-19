using System;

class Program
{
    static void Main()
    {
        // Запрашиваем трехзначное число
        Console.WriteLine("Введите трехзначное число:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Проверяем, что число действительно трехзначное
        if (number >= 100 && number <= 999)
        {
            // Находим число, полученное при прочтении его цифр справа налево
            int reversedNumber = (number % 10) * 100 + ((number / 10) % 10) * 10 + (number / 100);
            Console.WriteLine($"Число, полученное при прочтении цифр справа налево: {reversedNumber}");
        }
        else
        {
            Console.WriteLine("Введенное число не является трехзначным.");
        }
    }
}