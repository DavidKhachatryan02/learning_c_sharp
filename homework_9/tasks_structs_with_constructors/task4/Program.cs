namespace _homework_9_task_4
{
    using System;

    public struct Employee
    {
        public string Name;
        public int Id;
        public decimal Salary;

        public Employee(string name, int id, decimal salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }

        public void PrintInfo()
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("John Doe", 101, 55000);
            Console.WriteLine($"Employee: {emp.Name}, ID: {emp.Id}, Salary: ${emp.Salary}");
        }
    }
}
