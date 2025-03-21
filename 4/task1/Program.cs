using task1;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A(4, 16);

            int product = obj.CalculateProduct();
            Console.WriteLine($"Произведение a и b: {product}");

            double expressionValue = obj.CalculateExpression();
            Console.WriteLine($"Значение выражения √(b) / (2 * a): {expressionValue}");
        }
    }
}