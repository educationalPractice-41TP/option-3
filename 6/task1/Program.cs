using task1;

class Program
{
    static void Main(string[] args)
    {
        int r = 5;
        int h = 6;
        int w = 4;


        Shape[] shapes = new Shape[]
        {
            new Circle(r, "Круг"),
            new Rectangle(h, w, "Прямоугольник"),
            new Triangle(3, 7, "Треугольник")
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Площадь: {shape.GetArea()}");
        }
    }
}