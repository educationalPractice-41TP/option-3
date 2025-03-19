namespace task8
{
    class SquareCalculator
    {
        public int N { get; set; }

        public SquareCalculator(int n)
        {
            N = n;
        }

        public void CalculateAndPrintSquares()
        {
            int sum = 0;

            Console.WriteLine("Квадраты чисел от 1 до N:");

            for (int i = 1; i <= N; i++)
            {
                int currentOddNumber = 2 * i - 1; 
                sum += currentOddNumber;
                Console.WriteLine($"Сумма для {i}: {sum} (текущий нечетный: {currentOddNumber})");
            }
        }
    }
}
