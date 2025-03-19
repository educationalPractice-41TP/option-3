Console.WriteLine("Основная строка");
string input = Console.ReadLine();

Console.WriteLine("Подстрока");
string substring = Console.ReadLine();

int index = input.IndexOf(substring);

if (index != -1)
{
    Console.WriteLine($"Индекс первого вхождения подстроки: {index}");
}
else
{
    Console.WriteLine("Подстрока не найдена.");
}