namespace task3
{
    public class EmptyStringException : Exception
    {
        public EmptyStringException() : base("Строка не должна быть пустой или null.") { }

        public EmptyStringException(string message) : base(message) { }

        public EmptyStringException(string message, Exception innerException)
            : base(message, innerException) { }
    }

    public class StringProcessor
    {
        public void ValidateInput(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new EmptyStringException();
            }
        }
    }
}
