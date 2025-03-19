namespace task3
{
    class NumberRange
    {
        public int A { get; set; }
        public int B { get; set; }

        public NumberRange(int a, int b)
        {
            A = a;
            B = b;
        }

        public void DisplayNumbers()
        {
            List<int> numbers = new List<int>();

            for (int i = A + 1; i < B; i++)
            {
                numbers.Add(i);
            }

            numbers.Reverse(); // Сортируем в порядке убывания

            Console.WriteLine("Числа между A и B (в порядке убывания):");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine($"Количество чисел: {numbers.Count}");
        }
    }
}
