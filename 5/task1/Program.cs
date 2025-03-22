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
        string cleanedInput = input.Replace(" ", "").ToLower();

        char[] charArray = cleanedInput.ToCharArray();
        Array.Reverse(charArray);
        string reversedInput = new string(charArray);

        return cleanedInput == reversedInput;
    }
}
