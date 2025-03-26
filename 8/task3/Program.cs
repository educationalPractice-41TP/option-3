using task3;

class Program
{
    static void Main(string[] args)
    {
        StringProcessor processor = new StringProcessor();

        string input = ""; 

        try
        {
            processor.ValidateInput(input); 
        }
        catch (EmptyStringException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        input = "Hello, World!";
        try
        {
            processor.ValidateInput(input);
            Console.WriteLine("Строка валидна.");
        }
        catch (EmptyStringException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}