using System;

class Program
{
    static void Main()
    {
        // Запрашиваем три целых числа с клавиатуры
        Console.WriteLine("Введите три целых числа:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());

        // Вычисляем и выводим сумму чисел
        int sum = num1 + num2 + num3;
        Console.WriteLine($"Сумма чисел: {sum}");
    }
}