namespace _homework_3_task_13
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();
            int inputNumber = 0;
            int secretCode = random.Next(1000, 10000);
            do
            {
                Console.WriteLine("Enter your guess (4-digit code):");
                string input = Console.ReadLine();
                if (input.Length == 4)
                {
                    inputNumber = int.Parse(input);
                    if (inputNumber < secretCode)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (inputNumber > secretCode)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Congratulations! You've guessed the secret code!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a 4-digit number.");
                }
            } while (inputNumber != secretCode);
        }
    }
}