namespace _homework_2_task_8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of the triangle:");
            int n = int.Parse(Console.ReadLine());
            int i = 1;

            while (i <= n)
            {
                Console.WriteLine(new string('*', i));
                i++;
            }

            //interted 
            Console.WriteLine("Enter the intverted trinagle height:");
            int n1 = int.Parse(Console.ReadLine());
            int i1 = 1;

            while (i1 <= n1)
            {
                Console.WriteLine(new string('*', n1 - i1 + 1));
                i1++;
            }
        }
    }
}