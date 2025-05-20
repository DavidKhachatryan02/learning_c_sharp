using System;

namespace _homework_6_task_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your monthly income: ");
            if (!double.TryParse(Console.ReadLine(), out double income) || income <= 0)
            {
                Console.WriteLine("Invalid income input.");
                return;
            }

            Console.Write("Enter Rent expenses: ");
            double rent = double.Parse(Console.ReadLine());
            Console.Write("Enter groceries expenses: ");
            double groceries = double.Parse(Console.ReadLine());
            Console.Write("Enter Transport expenses: ");
            double transport = double.Parse(Console.ReadLine());

            Console.Write("Enter Entertainment expenses (optional): ");
            string? entertainmentInput = Console.ReadLine()?.Trim();
            double entertainment = Convert.ToDouble(entertainmentInput == "" ? "0" : entertainmentInput ?? "0");

            Console.Write("Enter other expenses (optional): ");
            string? otherInput = Console.ReadLine()?.Trim();
            double other = Convert.ToDouble(otherInput == "" ? "0" : otherInput ?? "0");

            double totalExpenses = rent + groceries + transport + entertainment + other;
            double balance = income - totalExpenses;

            Console.WriteLine("\n--- Budget Summary ---");
            Console.WriteLine($"Monthly Income:       {income}");
            Console.WriteLine($"Total Expenses:       {totalExpenses}");
            Console.WriteLine($"Remaining Balance:    {balance}");

            if (totalExpenses > income * 0.8)
            {
                Console.WriteLine("Warning: You are spending more than 80% of your income.");
            }

            if (balance < 0)
            {
                Console.WriteLine("Warning: You are over budget (negative balance).");
            }
        }
    }
}
