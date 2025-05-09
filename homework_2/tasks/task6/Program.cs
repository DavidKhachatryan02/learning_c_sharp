namespace _homework_2_task_6
{
    public class Program
    {
        static void Main()
        {
            string orderSummary = "";
            string more;

            do
            {
                Console.Write("Enter your order (e.g., burger, fries): ");
                string order = Console.ReadLine();

                if (orderSummary == "")
                {
                    orderSummary = order;
                }
                else
                {
                    orderSummary += ", " + order;
                }

                Console.Write("Do you want to add more? (yes/no): ");
                more = Console.ReadLine().Trim().ToLower();

            } while (more != "no");

            Console.WriteLine($"Your full order: ${orderSummary}");
        }
    }
}
