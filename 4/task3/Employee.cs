namespace task3
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        protected Employee(string name, int age, decimal salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
}