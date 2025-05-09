namespace _homework_2_task_7
{
    public class Program
    {
        static void Main(string[] args)
        {
//          Objective: Use a while loop to simulate watching stock prices.
// Task:
// Start with a random price (e.g., 100).
// Simulate the stock going up or down by 1–5 each time.
// Keep looping until the price reaches 120.
// Print the price at each step.

            Random random = new Random();
            int price = random.Next(0, 100); // Start with a random price between 95 and 105
            Console.WriteLine($"Starting price: {price}");

            while (price < 120)
            {
                int change = random.Next(1, 6);
                if (random.Next(2) == 0)
                {
                    price += change;
                }
                else
                {
                    price -= change;
                }

                Console.WriteLine($"Current price: {price}");
            }

            Console.WriteLine("Price reached 120 or more. Stopping simulation.");

        }
    }
}