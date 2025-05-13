namespace _homework_3_task_11
{
    public class Program
    {
        static void Main(string[] args)
        {
            double totalCost = 0;
            string itemCode;

            Console.WriteLine("Enter item code (A: Apple $2, B: Bread $3, C: Cheese $5) or 'done' to finish:");

            while ((itemCode = Console.ReadLine()) != "done")
            {
                switch (itemCode)
                {
                    case "A":
                        totalCost += 2;
                        break;
                    case "B":
                        totalCost += 3;
                        break;
                    case "C":
                        totalCost += 5;
                        break;
                    default:
                        Console.WriteLine("Invalid item code. Please enter A, B, C or 'done'.");
                        break;
                }
            }
            Console.WriteLine($"Total cost: ${totalCost}");
        }
    }
}