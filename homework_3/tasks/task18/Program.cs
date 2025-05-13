namespace _homework_3_task_18
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++) // 5 customers
            {
                Console.WriteLine("Parking Fee Calculator");
                Console.WriteLine("Enter hours parked (Enter 0 to finish):");

                int hours;

                Console.Write("Hours parked: ");
                hours = Convert.ToInt32(Console.ReadLine());

                int fee;

                if (hours == 0)
                {
                    fee = 0;
                    Console.WriteLine("No fee. Thank you!");
                }
                else if (hours >= 1 && hours <= 2)
                {
                    fee = 5;
                }
                else if (hours >= 3 && hours <= 5)
                {
                    fee = 10;
                }
                else
                {
                    fee = 15;
                }

                Console.WriteLine($"Parking fee: ${fee}");

                Console.WriteLine("Thank you! Have a great day!");
            }
        }
    }
}