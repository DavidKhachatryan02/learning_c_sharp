namespace _homework_3_task_15
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string correctUsername = "admin";
            const string correctPassword = "password";
            string username;
            string password;
            int attempts = 0;

            do
            {
                Console.WriteLine("Enter username:");
                username = Console.ReadLine();
                Console.WriteLine("Enter password:");
                password = Console.ReadLine();

                switch (username)
                {
                    case "admin":
                        if (password == correctPassword)
                        {
                            Console.WriteLine("Access granted");
                            return;    
                        }
                        else
                        {
                            Console.WriteLine("Incorrect password");
                            attempts++;
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Incorrect username");
                            attempts++;
                            break;
                        }
                }

                if (attempts < 3)
                {
                    Console.WriteLine($"You have {3 - attempts} attempts left.");
                }

            } while (attempts < 3);

            Console.WriteLine("Account Locked");
        }
    }
}
