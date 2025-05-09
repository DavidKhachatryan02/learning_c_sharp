namespace _homework_2_task_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many liters of fuel you need?");
            int liters = int.Parse(Console.ReadLine());
            int currentLiters = 0;
            while (currentLiters < liters)
            {
                currentLiters++;
                Console.WriteLine($"Pumped 1 liter. Total: {currentLiters}");
            }
        }
    }
}