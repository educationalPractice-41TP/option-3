namespace task3
{
    public class LogFileReader
    {
        private readonly string _filePath;

        public LogFileReader(string filePath)
        {
            _filePath = filePath;
        }

        public List<LogEntry> ReadLogs()
        {
            var logEntries = new List<LogEntry>();

            using (StreamReader reader = new StreamReader(_filePath))
            {
                string line;
                reader.ReadLine();
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(new[] { ": " }, 2, StringSplitOptions.None);
                    if (parts.Length == 2 && DateTime.TryParse(parts[0], out DateTime date))
                    {
                        logEntries.Add(new LogEntry(date, parts[1]));
                    }
                }
            }

            return logEntries;
        }
    }
}
