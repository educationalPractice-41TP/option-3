namespace task1
{
    public class Rectangle : Shape
    {
        private double width;
        private double height;
        private string name;

        public Rectangle(double width, double height, string name)
        {
            this.width = width;
            this.height = height;
            this.name = name;
        }

        public override double GetArea()
        {
            double areaR = width * height;
            Console.WriteLine(name);
            return areaR;
        }
    }
}
