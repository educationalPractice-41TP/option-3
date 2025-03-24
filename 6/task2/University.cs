namespace task2
{
    public class University
    {
        private Student[] students;
        private Department department;
        private Professor professor;

        public University(Department department, Professor professor)
        {
            this.department = department;
            this.professor = professor;
            this.students = new Student[0]; 
        }

        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }

        public void ShowStudents()
        {
            Console.WriteLine($"Университетский факультет: {department.Title}");
            Console.WriteLine("Студенты:");
            foreach (var student in students)
            {
                Console.WriteLine($"- {student.Name}");
            }
        }
    }
}
