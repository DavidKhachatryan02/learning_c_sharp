namespace _homework_1_task_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write any character");
            char char1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Write one more character");
            char char2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(char1 - char2);
        }
    }
}