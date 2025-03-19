using task2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите координаты точки (x и y):");

        Console.Write("x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        PointChecker pointChecker = new PointChecker(x, y);
        bool isInQuadrant = pointChecker.IsInFirstOrThirdQuadrant();

        if (isInQuadrant)
        {
            Console.WriteLine("Точка лежит в первой или третьей координатной четверти.");
        }
        else
        {
            Console.WriteLine("Точка не лежит в первой или третьей координатной четверти.");
        }
    }
}