using System;

class Program
{
    static void Main()
    {
        // Тестовые значения для alpha
        double[] testValues = { Math.PI / 6, Math.PI / 4, Math.PI / 3, Math.PI / 2, 2 * Math.PI / 3 };

        foreach (double alpha in testValues)
        {
            Console.WriteLine($"\nТестовый пример для alpha = {alpha} радиан:");

            // Вычисление z1
            double z1 = (Math.Sin(4 * alpha) / (1 + Math.Cos(4 * alpha))) * (Math.Cos(2 * alpha) / (1 + Math.Cos(2 * alpha)));

            // Вычисление z2
            double z2 = 1 / Math.Tan((3 * Math.PI / 2) - alpha);

            // Вывод результатов
            Console.WriteLine($"z1 = {z1:F4}");
            Console.WriteLine($"z2 = {z2:F4}");

            // Сравнение результатов
            if (Math.Abs(z1 - z2) < 0.0001)
            {
                Console.WriteLine("Результаты совпадают.");
            }
            else
            {
                Console.WriteLine("Результаты не совпадают.");
            }
        }
    }
}