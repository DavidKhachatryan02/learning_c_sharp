namespace _homework_2_task_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string snoozeResponse;
            do
            {
                Console.Write("Do you want to snooze the alarm? (Y/N): ");
                snoozeResponse = Console.ReadLine().ToUpper();

                if (snoozeResponse == "Y")
                {
                    Console.WriteLine("Snoozing for 5 more minutes...");
                }
                else if (snoozeResponse == "N")
                {
                    Console.WriteLine("Alarm turned off.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter Y or N.");
                }

            } while (snoozeResponse != "N");
        }
    }
}