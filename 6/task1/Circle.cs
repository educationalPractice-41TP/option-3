namespace task1
{
    public class Circle : Shape
    {
        private double radius;
        private string name;

        public Circle(double radius, string name)
        {
            this.radius = radius;
            this.name = name;
        }

        public override double GetArea()
        {
            double areaC = Math.PI * radius * radius;
            Console.WriteLine(name);
            return areaC;
        }
    }
}

