namespace _homework_3_task_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your income:");
            double income = double.Parse(Console.ReadLine());
            double tax = 0;

            if (income > 100000)
            {
                tax += 50000 * 0.10; 
                tax += 50000 * 0.20; 
                tax += (income - 100000) * 0.30;
            }
            else if (income > 50000)
            {
                tax += 50000 * 0.10;
                tax += (income - 50000) * 0.20;
            }
            else
            {
                tax = income * 0.10;
            }

            Console.WriteLine($"Your tax is: {tax}");
        }
    }
}