using task2;

public class Program
{
    public static void Main()
    {
        QueueProcessor<string> processor = new QueueProcessor<string>();

        // Добавляем задачи в очередь
        processor.AddTask("Задача 1");
        processor.AddTask("Задача 2");
        processor.AddTask("Задача 3");

        // Печатаем количество задач
        Console.WriteLine($"Всего задач: {processor.GetTaskCount()}");

        // Печатаем следующую задачу
        Console.WriteLine($"Следующая задача: {processor.PeekNextTask()}");

        // Обрабатываем задачи
        processor.ProcessTasks();

        // Печатаем количество задач после обработки
        Console.WriteLine($"Всего задач после обработки: {processor.GetTaskCount()}");
    }
}