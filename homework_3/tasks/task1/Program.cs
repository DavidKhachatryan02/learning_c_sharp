namespace _homework_3_task_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the baggage weight (in kg):");
            int weight = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the class (Economy, Business, First):");
            string classType = Console.ReadLine();

            int fee = 0;

            if (classType == "Economy")
            {
                if (weight > 20)
                {
                    fee = (weight - 20) * 10;
                }
            }
            if (classType == "Business")
            {
                if (weight > 30)
                {
                    fee = (weight - 30) * 8;
                }
            }
            if (classType == "First")
            {
                if (weight > 40)
                {
                    fee = (weight - 40) * 5;
                }
            }

            Console.WriteLine($"The baggage fee is: ${fee}");
        }
    }
}