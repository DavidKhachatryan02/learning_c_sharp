namespace _homework_3_task_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter ticket type (Standard, Fast):");
            string ticketType = Console.ReadLine();

            double price = 0;

            if (age < 5)
            {
                price = 0;
            }
            else if (age >= 5 && age <= 12)
            {
                if (ticketType == "Standard")
                {
                    price = 10;
                }
                else if (ticketType == "Fast")
                {
                    price = 15;
                }
            }
            else if (age >= 13 && age <= 64)
            {
                if (ticketType == "Standard")
                {
                    price = 20;
                }
                else if (ticketType == "Fast")
                {
                    price = 30;
                }
            }
            else
            {
                if (ticketType == "Standard")
                {
                    price = 12;
                }
                else if (ticketType == "Fast")
                {
                    price = 18;
                }
            }

            Console.WriteLine($"The ticket price is: ${price}");
        }
    }
}