namespace _homework_3_task_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter years of experience:");
            int experience = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter education level (High School/Bachelor/Master):");
            string education = Console.ReadLine();

            Console.WriteLine("Enter skill test score:");
            int score = int.Parse(Console.ReadLine());

            if (experience >= 5)
            {
                if (education == "Master" || education == "Bachelor")
                {
                    if (score >= 80)
                    {
                        Console.WriteLine("Highly Eligible");
                    }
                    else if (score >= 60)
                    {
                        Console.WriteLine("Eligible");
                    }
                    else
                    {
                        Console.WriteLine("Needs Improvement");
                    }
                }
                else
                {
                    Console.WriteLine("Education Not Sufficient");
                }
            }
            else
            {
                Console.WriteLine("Not Enough Experience");
            }
        }
    }
}