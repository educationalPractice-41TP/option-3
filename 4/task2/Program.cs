using task2;

class Program
{
    static void Main(string[] args)
    {
        Person[] people = {
                new Person("Павел", 28),
                new Person("Паша", 35),
                new Person("Пашок", 40),
                new Person("Пашка", 25),
                new Person("Пашуля", 32)
            };

        List<Person> filteredPeople = ArrayOperations.FilterByAge(people);

        Console.WriteLine("Люди старше 30 лет:");
        foreach (var person in filteredPeople)
        {
            Console.WriteLine($"Имя: {person.Name}, Возраст: {person.Age}");
        }
    }
}