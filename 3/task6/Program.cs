Console.WriteLine("Введите строку:");
string input = Console.ReadLine();

char longestChar = ' ';
char currentChar = ' ';
int longestCount = 0;
int currentCount = 1;

for (int i = 1; i < input.Length; i++)
{
    if (input[i] == input[i - 1])
    {
        currentCount++;
    }
    else
    {
        if (currentCount > longestCount)
        {
            longestCount = currentCount;
            longestChar = input[i - 1];
        }
        currentCount = 1;
    }
}

if (currentCount > longestCount)
{
    longestCount = currentCount;
    longestChar = input[input.Length - 1];
}

if (longestCount > 0)
{
    Console.WriteLine($"Самая длинная последовательность: '{longestChar}' (длина: {longestCount})");
}
else
{
    Console.WriteLine("Нет последовательностей символов.");
}