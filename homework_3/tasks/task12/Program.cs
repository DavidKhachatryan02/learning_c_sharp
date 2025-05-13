namespace _homework_3_task_12
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ('Exit' to quit):");
            string input = Console.ReadLine();

            while (input.ToLower() != "Exit")
            {
                if (double.TryParse(input, out double number))
                {
                    if (number < 0)
                    {
                        Console.WriteLine("Negative");
                    }
                    else if (number == 0)
                    {
                        Console.WriteLine("Zero");
                    }
                    else
                    {
                        Console.WriteLine("Positive");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                Console.WriteLine("Enter another number ('Exit' to quit):");
                input = Console.ReadLine();
            }

        }
    }
}