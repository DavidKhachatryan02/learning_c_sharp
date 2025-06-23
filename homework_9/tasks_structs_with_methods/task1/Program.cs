namespace _homework_9_task_1
{
    public struct Student
    {
        public string Name;
        public int Grade;

        public Student(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Student Name: {Name}, Grade: {Grade}");
        }
    }

    class Program
    {
        static void Main()
        {
            Student student1 = new Student("Anna", 92);
            student1.PrintInfo();
        }
    }
}
