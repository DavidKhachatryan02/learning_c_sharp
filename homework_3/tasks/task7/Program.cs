namespace _homework_3_task_7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meal type (breakfast, lunch, dinner):");
            string mealType = Console.ReadLine();

            Console.WriteLine("delivery or dinein:");
            string serviceType = Console.ReadLine();

            Console.WriteLine("time (24-hour format):");
            int time = int.Parse(Console.ReadLine());

            double surcharge = 0;

            if (serviceType == "delivery")
            {
                if (mealType == "dinner" && time > 20)
                {
                    surcharge += 5;
                }
                else if (mealType == "lunch")
                {
                    surcharge += 3;
                }
            }
            else if (serviceType == "dinein")
            {
                if (mealType == "Breakfast" && time < 8)
                {
                    surcharge += 2;
                }
            }

            Console.WriteLine($"Your surcharge is: ${surcharge}");
        }
    }
}