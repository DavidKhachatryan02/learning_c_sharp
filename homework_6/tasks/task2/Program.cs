using System.Text;
namespace _homework_6_task_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int balance = 10000;
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("ATM Menu:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option (1-4): ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Your current balance is: {balance}");
                        break;
                    case 2:
                        Console.Write("Enter amount to deposit: ");
                        int depositAmount = int.Parse(Console.ReadLine());
                        balance += depositAmount;
                        Console.WriteLine($"You have deposited {depositAmount}. New balance is: {balance}");
                        break;
                    case 3:
                        Console.Write("Enter amount to withdraw: ");
                        int withdrawAmount = int.Parse(Console.ReadLine());
                        if (withdrawAmount > balance)
                        {
                            Console.WriteLine("Not enough balance");
                        }
                        else
                        {
                            balance -= withdrawAmount;
                            Console.WriteLine($"You have withdrawn {withdrawAmount}. New balance is: {balance}");
                        }
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please choose again.");
                        break;
                }
            }


        }
    }
}