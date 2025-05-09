namespace _homework_2_task_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int roll;
            int rollCount = 0;

            do
            {
                roll = random.Next(1, 7);
                rollCount++;
                Console.WriteLine($"Roll {rollCount}: {roll}");
            } while (roll != 6);

            Console.WriteLine($"Total rolls until a 6: {rollCount}");
        }
    }
}