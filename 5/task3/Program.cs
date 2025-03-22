class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку для проверки:");
        string userInput = Console.ReadLine();

        if (IsPalindrome(userInput))
        {
            Console.WriteLine("Строка является палиндромом.");
        }
        else
        {
            Console.WriteLine("Строка не является палиндромом.");
        }
    }

    public static bool IsPalindrome(string input)
    {
        input = input.Replace(" ", "").ToLower();

        return CheckPalindrome(input, 0, input.Length - 1);
    }

    private static bool CheckPalindrome(string str, int left, int right)
    {
        if (left >= right)
        {
            return true;
        }

        if (str[left] != str[right])
        {
            return false; 
        }

        return CheckPalindrome(str, left + 1, right - 1);
    }
}
