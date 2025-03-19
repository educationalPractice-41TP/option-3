namespace task9
{
    class FunctionTabulator
    {
        public double A { get; set; }
        public double B { get; set; }
        public int M { get; set; }

        public FunctionTabulator(double a, double b, int m)
        {
            A = a;
            B = b;
            M = m;
        }

        public void TabulateCosine()
        {
            double H = (B - A) / M;

            Console.WriteLine("Табуляция функции F(x) = cos(x):");
            Console.WriteLine("x \t\t F(x)");

            double x = A;
            for (int i = 0; i <= M; i++)
            {
                double y = Math.Cos(x);
                Console.WriteLine($"{x:F2} \t {y:F4}");
                x += H;
            }
        }
    }
}
