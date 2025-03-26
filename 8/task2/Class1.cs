using System;
using System.Data.SqlClient;
using System.IO;

namespace task2
{
    // 1. Создание пользовательского исключения для подключения к базе данных
    public class DatabaseConnectionException : Exception
    {
        public DatabaseConnectionException(string message, Exception innerException)
            : base(message, innerException) { }
    }

    // Класс для подключения к базе данных
    public class DatabaseConnector
    {
        public void Connect(string connectionString)
        {
            // Искусственно выбрасываем исключение для демонстрации
            throw new Exception("Ошибка при подключении к базе данных.");
        }
    }

    // Класс для управления подключениями к базе данных
    public class DatabaseManager
    {
        private DatabaseConnector _connector = new DatabaseConnector();

        public void ConnectToDatabase(string connectionString)
        {
            try
            {
                _connector.Connect(connectionString);
            }
            catch (Exception ex)
            {
                // 2. Оборачивание исключения
                throw new DatabaseConnectionException("Не удалось подключиться к базе данных.", ex);
            }
        }
    }
}
