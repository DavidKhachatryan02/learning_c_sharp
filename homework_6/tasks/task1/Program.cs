using System.Text;
namespace _homework_6_task_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter vehicle details:");
                Console.Write("Brand: ");
                string brand = Console.ReadLine();
                Console.Write("Model: ");
                string model = Console.ReadLine();
                Console.Write("Year: ");
                int year = int.Parse(Console.ReadLine());

                if (year < 1980 || year > DateTime.Now.Year)
                {
                    Console.WriteLine("Invalid year. Year should be between 1980 and the current year.");
                    return
                }

                Console.Write("Engine Capacity: ");
                double engineCapacity = double.Parse(Console.ReadLine());

                if (engineCapacity <= 0)
                {
                    Console.WriteLine("Invalid engine capacity. It should be greater than 0.");
                    return;
                }

                Console.Write("Owner Name: ");
                string ownerName = Console.ReadLine();
                int currentYear = DateTime.Now.Year;
                StringBuilder registrationRecord = new StringBuilder();
                registrationRecord.AppendLine($"Brand: {brand}");
                registrationRecord.AppendLine($"Model: {model}");
                registrationRecord.AppendLine($"Year: {year}");
                registrationRecord.AppendLine($"Engine Capacity: {engineCapacity}");
                registrationRecord.AppendLine($"Owner Name: {ownerName}");
                registrationRecord.AppendLine($"Registration Year: {currentYear}");

                Console.WriteLine("Vehicle Registration Record:");
                Console.WriteLine("===================================");

                Console.WriteLine(registrationRecord.ToString());
            }
        }
    }
}