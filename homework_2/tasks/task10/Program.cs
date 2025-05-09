namespace _homework_2_task_10
{
    public class Program
    {
        static void Main(string[] args)
        {
            // pyramid
            Console.WriteLine("Enter the size of the pyramid (n):");
            int pyramidSize = int.Parse(Console.ReadLine());
            int pyramidRow = 0;
            while (pyramidRow < pyramidSize)
            {
                Console.WriteLine($"{new string(' ', pyramidSize - pyramidRow - 1)}{new string('*', pyramidRow * 2 + 1)}");
                pyramidRow++;
            }

            //stairCase

            Console.WriteLine("Enter the size of the stairCase (n):");
            int size = int.Parse(Console.ReadLine());
            int row = 0;
            while (row < size)
            {
                Console.WriteLine($"{new string(' ', size - row - 1)}{new string('*', row + 1)}");
                row++;
            }
        }
    }
}