namespace _homework_3_task_20
{
    public class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Game Menu:");
                Console.WriteLine("1. Start Game");
                Console.WriteLine("2. Load Game");
                Console.WriteLine("3. Quit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Starting a new game...");
                        break;
                    case 2:
                        Console.WriteLine("Loading saved game...");
                        break;
                    case 3:
                        Console.WriteLine("Quitting the game. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 3);
        }
    }
}