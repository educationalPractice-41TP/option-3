using task2;

class Program
{
    static void Main(string[] args)
    {
        DatabaseManager dbManager = new DatabaseManager();

        try
        {
            dbManager.ConnectToDatabase("YourConnectionStringHere");
        }
        catch (DatabaseConnectionException ex)
        {
            LogError(ex);
            Console.WriteLine($"Ошибка: {ex.Message}");
            Console.WriteLine($"Внутреннее исключение: {ex.InnerException?.Message}");
        }
    }

    private static void LogError(Exception ex)
    {
        string logFilePath = "error_log.txt";
        using (StreamWriter writer = new StreamWriter(logFilePath, true))
        {
            writer.WriteLine($"[{DateTime.Now}] Ошибка: {ex.Message}");
            writer.WriteLine($"Стек вызовов: {ex.StackTrace}");
            if (ex.InnerException != null)
            {
                writer.WriteLine($"Внутреннее исключение: {ex.InnerException.Message}");
                writer.WriteLine($"Стек вызовов внутреннего исключения: {ex.InnerException.StackTrace}");
            }
            writer.WriteLine(new string('-', 50));
        }
    }
}