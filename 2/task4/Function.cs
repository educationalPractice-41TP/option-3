namespace task4
{
    class Function
    {
        public double X { get; set; }

        public Function(double x)
        {
            X = x;
        }

        public double CalculateY()
        {
            if (X < 1.3)
            {
                return Math.PI * Math.Pow(X, 2) - 7 / Math.Sqrt(Math.Abs(X));
            }
            else
            {
                return 3 * X - Math.Cos(Math.Pow(X, 2));
            }
        }
    }
}
