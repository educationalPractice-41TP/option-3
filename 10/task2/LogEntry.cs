namespace task2
{
    public class LogEntry
    {
        public DateTime Date { get; set; }
        public string Message { get; set; }

        public LogEntry(DateTime date, string message)
        {
            Date = date;
            Message = message;
        }

        public override string ToString()
        {
            return $"{Date.ToString("o")}: {Message}";
        }
    }
}
