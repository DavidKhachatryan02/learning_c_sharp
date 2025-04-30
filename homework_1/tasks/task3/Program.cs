namespace _homework_1_task_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is you favorite color?");
            string color = Console.ReadLine();
            if (string.IsNullOrEmpty(color))
            {
                Console.WriteLine("Please enter a color.");
                return;
            }
            Console.WriteLine("What is you favorite animal?");
            string animal = Console.ReadLine();

            if (string.IsNullOrEmpty(animal))
            {
                Console.WriteLine("Please enter an animal.");
                return;
            }

            Console.WriteLine($"Your funny name is: {color.ToUpper()} {animal.ToLower()}!");
        }
    }
}