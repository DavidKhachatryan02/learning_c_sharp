namespace _homework_3_task_2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter GPA:");
            double gpa = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your attendance percentage:");
            double attendance = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your community service hours:");
            int serviceHours = int.Parse(Console.ReadLine());

            if (gpa >= 3.5 && attendance >= 90)
            {
                if (serviceHours >= 20)
                {
                    Console.WriteLine("You are eligible for a Full Scholarship.");
                }
                else if (serviceHours >= 10)
                {
                    Console.WriteLine("You are eligible for a Half Scholarship.");
                }
                else
                {
                    Console.WriteLine("You are eligible for an Academic Scholarship Only.");
                }
            }
            else
            {
                Console.WriteLine("You are not eligible for any scholarship.");
            }
        }
    }
}