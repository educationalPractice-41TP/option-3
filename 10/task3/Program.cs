using task3;

class Program
{
    static void Main()
    {
        string filePath = "file.data";

        LogFileWriter logWriter = new LogFileWriter(filePath);
        logWriter.AppendLogEntry(new LogEntry(DateTime.Now, "Первая запись в лог."));
        logWriter.AppendLogEntry(new LogEntry(DateTime.Now.AddDays(1), "Вторая запись в лог."));
        logWriter.AppendLogEntry(new LogEntry(DateTime.Now.AddDays(2), "Третья запись в лог."));

        LogFileReader logReader = new LogFileReader(filePath);
        List<LogEntry> logEntries = logReader.ReadLogs();

        LogProcessor logProcessor = new LogProcessor(logEntries);

        DateTime fromDate = DateTime.Now.AddDays(-1);
        DateTime toDate = DateTime.Now.AddDays(2);
        var filteredLogs = logProcessor.FilterLogsByDate(fromDate, toDate);

        Console.WriteLine("Отфильтрованные логи:");
        if (!filteredLogs.Any())
        {
            Console.WriteLine("Нет логов за указанный период.");
        }
        else
        {
            foreach (var log in filteredLogs)
            {
                Console.WriteLine(log);
            }
        }
    }
}