namespace _homework_3_task_17
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Grade Analyzer");
            Console.WriteLine("Enter scores (0-100). Enter a negative number to stop.\n");

            Console.Write("Enter score: ");
            int score = int.Parse(Console.ReadLine());

            while (score >= 0)
            {
                if (score > 100)
                {
                    Console.WriteLine("Invalid score. Please enter a number between 0 and 100.");
                }
                else if (score >= 90)
                {
                    Console.WriteLine("Grade: A");
                }
                else if (score >= 80)
                {
                    Console.WriteLine("Grade: B");
                }
                else if (score >= 70)
                {
                    Console.WriteLine("Grade: C");
                }
                else if (score >= 60)
                {
                    Console.WriteLine("Grade: D");
                }
                else
                {
                    Console.WriteLine("Grade: F");
                }

                Console.Write("Enter score: ");
                score = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Exiting program.");
        }
    }
}