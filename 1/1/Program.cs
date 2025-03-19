Console.WriteLine("Вычисление площади поверхности. ");

Console.WriteLine("Введите радиус основания (см):");

double radius = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите высоту цилиндра (см):");

double height = Convert.ToDouble(Console.ReadLine());

double S = 2 * Math.PI * radius * (radius + height);

Console.WriteLine($"S={S:F2} кв.см");