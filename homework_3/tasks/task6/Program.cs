namespace _homework_3_task_6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter item price:");
            double itemPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter quantity:");
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter customer type (regular, vip):");
            string customerType = Console.ReadLine();

            double discount = 0;

            if (quantity > 100)
            {
                if (customerType == "vip")
                {
                    discount = 0.20;
                }
                else
                {
                    discount = 0.10;
                }
            }
            else if (quantity > 50)
            {
                if (customerType == "vip")
                {
                    discount = 0.15;
                }
                else
                {
                    discount = 0.05;
                }
            }
            else
            {
                if (customerType == "vip")
                {
                    discount = 0.10;
                }
                else
                {
                    discount = 0.00;
                }
            }

            double finalPrice = itemPrice * quantity * (1 - discount);
            Console.WriteLine($"Final price after discount: ${finalPrice}, discount: {discount * 100}%");
        }
    }
}