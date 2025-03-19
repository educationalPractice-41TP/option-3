int size = 100; 
int[] numbers = new int[size];
Random random = new Random();

for (int i = 0; i < size; i++)
{
    numbers[i] = random.Next(-50, 51); 
}

Console.WriteLine("Исходный массив:");
PrintArray(numbers);

Array.Sort(numbers);

Console.WriteLine("Отсортированный массив:");
PrintArray(numbers);


Console.WriteLine("Отрицательные числа:");
foreach (int number in numbers)
{
    if (number < 0)
    {
        Console.WriteLine(number);
    }
}

Console.WriteLine("Остальные числа:");
foreach (int number in numbers)
{
    if (number >= 0)
    {
        Console.WriteLine(number);
    }
}


Console.WriteLine("Введите число для поиска (k):");
int k = Convert.ToInt32(Console.ReadLine());

int index = Array.BinarySearch(numbers, k);
if (index >= 0)
{
    Console.WriteLine($"Число {k} найдено по индексу {index}.");
}
else
{
    Console.WriteLine($"Число {k} не найдено.");
}


static void PrintArray(int[] array)
{
    foreach (int number in array)
    {
        Console.Write(number + " ");
    }
    Console.WriteLine();
}
