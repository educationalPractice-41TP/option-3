using task2;

namespace task2
{
    public static class ArrayOperations
    {
        public static List<Person> FilterByAge(Person[] people)
        {
            return people.Where(person => person.Age > 30).ToList();
        }
    }
}

