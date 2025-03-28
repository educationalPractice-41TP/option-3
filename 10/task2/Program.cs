using task2;

class Program
{
    static void Main()
    {
        string filePath = "file.data";
        LogFileWriter logWriter = new LogFileWriter(filePath);

        logWriter.AppendLogEntry(new LogEntry(DateTime.Now, "Первая запись в лог."));
        logWriter.AppendLogEntry(new LogEntry(DateTime.Now, "Вторая запись в лог."));

        Console.WriteLine("Записи добавлены в файл file.data.");
    }
}