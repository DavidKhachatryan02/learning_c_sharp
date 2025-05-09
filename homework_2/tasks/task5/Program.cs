namespace _homework_2_task_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many packages are left to deliver?");
            int packages = int.Parse(Console.ReadLine());
            while (packages > 0)
            {
                Console.WriteLine($"Packages left: {packages}");
                packages--;
            }
            Console.WriteLine("All packages delivered!");
        }
    }
}