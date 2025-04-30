namespace _homework_1_task_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write 8 character long string");
            string str = Console.ReadLine();
            if (str.Length != 8)
            {
                Console.WriteLine("String must be 8 characters long");
                return;
            }

            Console.WriteLine($"{str[7]}{str[6]}{str[5]}{str[4]}{str[3]}{str[2]}{str[1]}{str[0]}");
        }
    }
}