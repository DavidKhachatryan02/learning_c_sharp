namespace _homework_3_task_10
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter age group (child, teen, adult):");
            string ageGroup = Console.ReadLine();

            Console.WriteLine("Enter IQ score:");
            int iqScore = int.Parse(Console.ReadLine());

            if (ageGroup == "child")
            {
                if (iqScore < 80)
                {
                    Console.WriteLine("Needs Support");
                }
                else if (iqScore > 110)
                {
                    Console.WriteLine("Gifted");
                }
                else
                {
                    Console.WriteLine("Average");
                }
            }
            else if (ageGroup == "teen")
            {
                if (iqScore < 90)
                {
                    Console.WriteLine("Below Average");
                }
                else if (iqScore > 120)
                {
                    Console.WriteLine("Advanced");
                }
                else
                {
                    Console.WriteLine("Average");
                }
            }
            else if (ageGroup == "adult")
            {
                if (iqScore < 100)
                {
                    Console.WriteLine("Below Normal");
                }
                else if (iqScore > 130)
                {
                    Console.WriteLine("High IQ");
                }
                else
                {
                    Console.WriteLine("Normal");
                }
            }
            else
            {
                Console.WriteLine("Invalid age group.");
            }

        }
    }
}