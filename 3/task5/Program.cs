int[][] steppedArray = new int[5][];
Random random = new Random();

for (int i = 0; i < steppedArray.Length; i++)
{
    steppedArray[i] = new int[random.Next(3, 6)]; 
    for (int j = 0; j < steppedArray[i].Length; j++)
    {
        steppedArray[i][j] = random.Next(1, 10); 
    }
}

Console.WriteLine("Исходный ступенчатый массив:");
PrintsteppedArray(steppedArray);

Array.Sort(steppedArray, (a, b) => GetSum(b).CompareTo(GetSum(a)));

Console.WriteLine("\nСтупенчатый массив после сортировки по убыванию суммы строк:");
PrintsteppedArray(steppedArray);


static int GetSum(int[] row)
{
    int sum = 0;
    foreach (var num in row)
    {
        sum += num;
    }
    return sum;
}

static void PrintsteppedArray(int[][] array)
{
    foreach (var row in array)
    {
        Console.WriteLine(string.Join("\t", row));
    }
}
