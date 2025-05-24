using Product_Task_3;
namespace _homework_7_task_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var product1 = new Product("Product1", "Description1");
            var product2 = new Product("Product2");

            System.Console.WriteLine($"Product 1: {product1.Name}, Description: {product1.Description ?? "No description available"}");
            System.Console.WriteLine($"Product 2: {product2.Name}, Description: {product2.Description ?? "No description available"}");
        }
    }
}