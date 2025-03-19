using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите длину окружности: ");
        double length = Convert.ToDouble(Console.ReadLine());

        double area = (length * length) / (4 * Math.PI);

        Console.WriteLine($"Площадь круга: {area}");
    }
}