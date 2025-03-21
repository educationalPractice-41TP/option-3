namespace task1
{
    public class A
    {
        private int a;
        private int b;

        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int CalculateProduct()
        {
            return a * b;
        }

        public double CalculateExpression()
        {
            return Math.Sqrt(b) / (2 * a);
        }
    }
}
