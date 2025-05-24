using System.Text;
namespace _homework_7_task_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Dicsunt code:");
            string? discountCode = Console.ReadLine();
            discountCode = string.IsNullOrEmpty(discountCode) ? null : discountCode;
            Console.WriteLine($"Dicsunt code is: {discountCode ?? "No Code Entered"}");
        }
    }
}