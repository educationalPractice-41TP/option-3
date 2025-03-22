class Program
{
    static void Main(string[] args)
    {
        double side1 = 5.0;
        double side2 = 7.0;
        double side3 = 10.0;

        CalculateAndDisplayTriangleProperties(side1);
        CalculateAndDisplayTriangleProperties(side2);
        CalculateAndDisplayTriangleProperties(side3);
    }

    static void CalculateAndDisplayTriangleProperties(double a)
    {
        double P, S;
        TrianglePS(a, out P, out S);
        Console.WriteLine($"Для треугольника со стороной {a}: Периметр = {P}, Площадь = {S}");
    }

    public static void TrianglePS(double a, out double P, out double S)
    {
        P = 3 * a; 
        S = Math.Sqrt(3) / 4 * a * a; 
    }
}
