namespace _homework_9_task_3
{
    public enum GradeLevel
    {
        Freshman,
        Sophomore,
        Junior,
        Senior
    }

    public struct Student
    {
        public string Name;
        public int Age;
        public GradeLevel Grade;

        public Student(string name, int age, GradeLevel grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Davit", 18, GradeLevel.Freshman);
            Student student2 = new Student("Gag", 21, GradeLevel.Senior);

            Console.WriteLine($"Name: {student1.Name}, Age: {student1.Age}, Grade Level: {student1.Grade}");
            Console.WriteLine($"Name: {student2.Name}, Age: {student2.Age}, Grade Level: {student2.Grade}");
        }
    }
}
