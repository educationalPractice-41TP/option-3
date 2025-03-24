namespace task1
{
    public class Triangle : Shape
    {
        private double baseLength;
        private double height;
        private string name;

        public Triangle(double baseLength, double height, string name)
        {
            this.baseLength = baseLength;
            this.height = height;
            this.name = name;
        }

        public override double GetArea()
        {
            double areaT = 0.5 * baseLength * height;
            Console.WriteLine(name);
            return areaT;
        }
    }
}
