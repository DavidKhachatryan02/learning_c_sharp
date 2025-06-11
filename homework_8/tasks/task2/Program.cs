namespace _homework_8_task_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] studentsArr = ["John", "DOE", "Bla", "YES", "True"];
            for (int i = 0; i < studentsArr.Length; i++)
            {
                Console.WriteLine($"Student name: {studentsArr[studentsArr.Length - 1 - i]}");
            }
        }
    }
}