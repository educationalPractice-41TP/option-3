namespace task5
{
    class OddChecker
    {
        public int Number { get; set; }

        public OddChecker(int number)
        {
            Number = number;
        }

        public bool IsOdd()
        {
            return Number % 2 != 0;
        }
    }
}
