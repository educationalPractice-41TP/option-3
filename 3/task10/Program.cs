using System.Text.RegularExpressions;

Console.WriteLine("Введите дату в формте дд.мм.гггг:");
string input = Console.ReadLine();
string pattern = @"\b\d{2}\.\d{2}\.\d{4}\b";
MatchCollection matches = Regex.Matches(input, pattern);

if (matches.Count > 0)
{
    foreach (Match match in matches)
    {
        Console.WriteLine(match.Value);
    }
}
else
{
    Console.WriteLine("Даты не найдены.");
}