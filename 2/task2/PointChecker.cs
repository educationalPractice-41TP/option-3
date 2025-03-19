namespace task2
{
    class PointChecker
    {
        public double X { get; set; }
        public double Y { get; set; }

        public PointChecker(double x, double y)
        {
            X = x;
            Y = y;
        }

        public bool IsInFirstOrThirdQuadrant()
        {
            return (X > 0 && Y > 0) || (X < 0 && Y < 0);
        }
    }
}
