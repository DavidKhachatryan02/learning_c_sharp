namespace _homework_3_task_14
{
    public class Program
    {
        static void Main()
        {
            Random random = new Random();
            int slot1, slot2, slot3;
            int choice;

            do
            {
                slot1 = random.Next(1, 4);
                slot2 = random.Next(1, 4);
                slot3 = random.Next(1, 4);

                switch (slot1)
                {
                    case 1: Console.Write("🍒 "); break;
                    case 2: Console.Write("🍋 "); break;
                    case 3: Console.Write("🔔 "); break;
                }

                switch (slot2)
                {
                    case 1: Console.Write("🍒 "); break;
                    case 2: Console.Write("🍋 "); break;
                    case 3: Console.Write("🔔 "); break;
                }

                switch (slot3)
                {
                    case 1: Console.Write("🍒 "); break;
                    case 2: Console.Write("🍋 "); break;
                    case 3: Console.Write("🔔 "); break;
                }

                if (slot1 == slot2 && slot2 == slot3)
                {
                    Console.WriteLine("🎉 Big Win!");
                }
                else if (slot1 == slot2 || slot2 == slot3 || slot1 == slot3)
                {
                    Console.WriteLine("😊 Small Win!");
                }
                else
                {
                    Console.WriteLine("🙃 Try Again!");
                }

                Console.WriteLine("Press p to play again, q to quit.");
                string input = Console.ReadLine();
                if (input == "p")
                {
                    choice = 1;
                }
                else if (input == "q")
                {
                    choice = 0;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'p' to play again or 'q' to quit.");
                    choice = 1; // Default to play again if input is invalid}
                }
            } while (choice == 1);

            Console.WriteLine("Thanks for playing!");
        }
    }
}