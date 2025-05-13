namespace _homework_3_task_9
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your income:");
            int income = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your credit score:");
            int creditScore = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            if (age >= 21)
            {
                if (income >= 30000)
                {
                    if (creditScore >= 700)
                    {
                        Console.WriteLine("Approved");
                    }
                    else if (creditScore >= 600)
                    {
                        Console.WriteLine("Approved with Low Limit");
                    }
                    else
                    {
                        Console.WriteLine("Denied");
                    }
                }
                else
                {
                    Console.WriteLine("Low Income - Denied");
                }
            }
            else
            {
                Console.WriteLine("Too Young - Denied");
            }
        }
    }
}