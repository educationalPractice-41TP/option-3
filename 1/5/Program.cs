using System;

class Program
{
    static void Main()
    {
        double x = 0.7;

        // Вычисляем e^x
        double expX = Math.Exp(x);

        // Вычисляем cos(e^x)
        double cosExpX = Math.Cos(expX);

        // Проверяем, что cos(e^x) > 0, чтобы логарифм был определен
        if (cosExpX <= 0)
        {
            Console.WriteLine("Ошибка: cos(e^x) меньше или равен нулю, логарифм не определен.");
            return;
        }

        // Вычисляем ln(cos(e^x))
        double lnCosExpX = Math.Log(cosExpX);

        // Вычисляем sin(x)^3
        double sinXCubed = Math.Pow(Math.Sin(x), 3);

        // Вычисляем |1 - x^2|
        double absTerm = Math.Abs(1 - Math.Pow(x, 2));

        // Проверяем, что знаменатель не равен нулю и не отрицательный
        double denominator = Math.Sqrt(sinXCubed + absTerm);
        if (denominator <= 0)
        {
            Console.WriteLine("Ошибка: знаменатель меньше или равен нулю.");
            return;
        }

        // Вычисляем значение функции y
        double y = 20 * lnCosExpX - 2 / denominator;

        // Выводим результат
        Console.WriteLine($"Значение функции y при x = {x}: {y}");
    }
}