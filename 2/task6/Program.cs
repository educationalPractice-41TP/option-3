using task6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите возраст человека в годах:");

        int age = Convert.ToInt32(Console.ReadLine());

        AgeCategory ageCategory = new AgeCategory(age);
        string category = ageCategory.GetCategory();

        Console.WriteLine($"Возрастная категория: {category}");
    }
}