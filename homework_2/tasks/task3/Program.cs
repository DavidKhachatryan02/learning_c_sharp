namespace _homework_2_task_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            string correctPin = "1234";
            string enteredPin;
            int attempts = 0;
            int maxAttempts = 3;

            do
            {
                Console.Write("Enter your 4-digit PIN: ");
                enteredPin = Console.ReadLine();
                attempts++;

                if (enteredPin == correctPin)
                {
                    Console.WriteLine("Access granted.");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect PIN. Try again.");
                }

            } while (attempts < maxAttempts);

            if (attempts == maxAttempts && enteredPin != correctPin)
            {
                Console.WriteLine("Card blocked.");
            }
        }
    }
}