namespace task2
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
            try
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
            catch (IOException ex)
            {
                Console.WriteLine($"Ошибка при записи в файл: {ex.Message}");
            }
        }
    }
}
