namespace task3
{
    public class Company
    {
        private Employee[] employees;

        public Company(Employee[] employees)
        {
            this.employees = employees;
        }

        public Employee GetHighestPaidEmployee()
        {
            return employees.OrderByDescending(emp => emp.Salary).FirstOrDefault();
        }

        public double GetAverageAge()
        {
            return employees.Average(emp => emp.Age);
        }
    }
}