namespace _homework_3_task_8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter city (Tier 1, Tier 2):");
            string city = Console.ReadLine();

            Console.WriteLine("Enter apartment type (1BHK, 2BHK, 3BHK):");
            string apartmentType = Console.ReadLine();

            Console.WriteLine("Amenities (yes/no):");
            string amenities = Console.ReadLine();

            double baseRent = 0;

            if (city == "Tier 1")
            {
                if (apartmentType == "1BHK")
                {
                    baseRent = 800;
                }
                else if (apartmentType == "2BHK")
                {
                    baseRent = 1200;
                }
                else if (apartmentType == "3BHK")
                {
                    baseRent = 1600;
                }
            }
            else if (city == "Tier 2")
            {
                if (apartmentType == "1BHK")
                {
                    baseRent = 600;
                }
                else if (apartmentType == "2BHK")
                {
                    baseRent = 900;
                }
                else if (apartmentType == "3BHK")
                {
                    baseRent = 1200;
                }
            }

            if (amenities == "yes")
            {
                baseRent += 100;
            }

            Console.WriteLine($"Final rent: ${baseRent}");
        }
    }
}