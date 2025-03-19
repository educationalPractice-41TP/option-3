using task9;

class Program
{
    static void Main(string[] args)
    {
        double A = Math.PI / 3; // π/3
        double B = 2 * Math.PI / 3; // 2π/3
        int M = 20;

        FunctionTabulator tabulator = new FunctionTabulator(A, B, M);
        tabulator.TabulateCosine();
    }
}