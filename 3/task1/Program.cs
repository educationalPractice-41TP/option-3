int[] numbers = { 1, 2, 3,44, 86,  4, 5, 6, 7, 8, 9, 10, 11 , 12, 13 };

Console.WriteLine("Порядковые номера нечетных элементов:");

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 != 0) 
    {
        Console.WriteLine(i + 1); 
    }
}
