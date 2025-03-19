namespace task10
{
    class DigitCounter
    {
        public int Number { get; set; }
        public int Digit { get; set; }

        public DigitCounter(int number, int digit)
        {
            Number = number;
            Digit = digit;
        }

        public int CountDigitOccurrences()
        {
            int count = 0;
            int tempNumber = Math.Abs(Number);

            while (tempNumber > 0)
            {
                int currentDigit = tempNumber % 10;
                if (currentDigit == Digit)
                {
                    count++;
                }
                tempNumber /= 10;
            }

            return count;
        }
    }
}
