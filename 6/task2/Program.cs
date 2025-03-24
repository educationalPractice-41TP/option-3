using task2;

class Program
{
    static void Main(string[] args)
    {
        Department csDepartment = new Department("Информатика");
        Professor drSmith = new Professor("Стрехаха");

        University university1 = new University(csDepartment, drSmith);
        university1.AddStudent(new Student("Алсиса"));
        university1.AddStudent(new Student("Боб"));

        University university2 = new University(new Department("Математика"), drSmith);
        university2.AddStudent(new Student("Женя"));

        University[] universities = new University[] { university1, university2 };

        foreach (var university in universities)
        {
            university.ShowStudents();
            Console.WriteLine();
        }
    }
}