namespace task3
{
    public class LogFileWriter
    {
        private readonly string _filePath;

        public LogFileWriter(string filePath)
        {
            _filePath = filePath;
        }

        public void AppendLogEntry(LogEntry entry)
        {
            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                if (new FileInfo(_filePath).Length == 0)
                {
                    writer.WriteLine("Log Entries:");
                }
                writer.WriteLine(entry.ToString());
            }
        }
    }
}
