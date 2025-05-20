using System.Text;
namespace _homework_6_task_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            double totalPrice = 0;
            StringBuilder invoice = new StringBuilder("--- Invoice ---");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter product name:");
                string productName = Console.ReadLine();
                Console.WriteLine("Enter product price:");
                double productPrice = double.Parse(Console.ReadLine());

                if (productPrice <= 0)
                {
                    Console.WriteLine("Invalid price. It should be greater than 0.");
                    return;
                }

                invoice.AppendLine($"Product Name: {productName}, Price: {productPrice}");

                totalPrice += productPrice;

            }
            if (totalPrice > 100)
            {
                totalPrice *= 0.9;
            }
            invoice.AppendLine("--- TOTAL ---");
            invoice.AppendLine($"Total Price: {totalPrice}");
            Console.WriteLine(invoice.ToString());
        }
    }
}