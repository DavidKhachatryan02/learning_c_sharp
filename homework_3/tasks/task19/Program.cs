namespace _homework_3_task_19
{
    public class Program
    {
        static void Main(string[] args)
        {
            double totalBeforeDiscount = 0;
            double totalAfterDiscount = 0;
            double price;

            Console.WriteLine("Enter item prices (Enter 0 to finish):");

            Console.Write("Price: $");
            price = Convert.ToDouble(Console.ReadLine());

            while (price != 0)
            {
                totalBeforeDiscount += price;

                if (price > 100)
                {
                    price *= 0.9;
                }

                totalAfterDiscount += price;

                Console.Write("Price: $");
                price = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine($"\nTotal before discount: ${totalBeforeDiscount:F2}");
            Console.WriteLine($"Total after discount: ${totalAfterDiscount:F2}");
        }
    }
}