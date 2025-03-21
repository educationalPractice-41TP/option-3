using task3;

class Program
{
    static void Main(string[] args)
    {
        Employee[] employees = {
            new Manager("Боба", 40, 80000m),
            new Developer("Биба", 30, 60000m),
            new Developer("Кирилл", 35, 70000m),
            new Manager("Давид", 45, 90000m),
            new Developer("Ева", 28, 50000m)
        };

        Company company = new Company(employees);

        Employee highestPaid = company.GetHighestPaidEmployee();
        Console.WriteLine($"Сотрудник с самой высокой зарплатой: {highestPaid.Name}, Зарплата: {highestPaid.Salary}");

        double averageAge = company.GetAverageAge();
        Console.WriteLine($"Средний возраст сотрудников: {averageAge}");
    }
}