int numberOfPeople = 18; 
int monthsInYear = 12;  
decimal[,] salaries = new decimal[numberOfPeople, monthsInYear];
Random random = new Random();

for (int i = 0; i < numberOfPeople; i++)
{
    for (int j = 0; j < monthsInYear; j++)
    {
        salaries[i, j] = random.Next(1000, 5001);
    }
}

Console.WriteLine("Зарплаты 18 человек за каждый месяц:");
for (int i = 0; i < numberOfPeople; i++)
{
    Console.Write($"Человек {i + 1}: ");
    for (int j = 0; j < monthsInYear; j++)
    {
        Console.Write(salaries[i, j] + "\t");
    }
    Console.WriteLine();
}

decimal annualIncomeFirstPerson = 0;
for (int j = 0; j < monthsInYear; j++)
{
    annualIncomeFirstPerson += salaries[0, j];
}

Console.WriteLine("\nВведите заданное число для проверки годового дохода первого человека:");
decimal threshold = Convert.ToDecimal(Console.ReadLine());

if (annualIncomeFirstPerson > threshold)
{
    Console.WriteLine($"Годовой доход первого человека ({annualIncomeFirstPerson}) больше {threshold}.");
}
else
{
    Console.WriteLine($"Годовой доход первого человека ({annualIncomeFirstPerson}) не превышает {threshold}.");
}
