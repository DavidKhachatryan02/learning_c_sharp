namespace _homework_2_task_9
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the solid square (n):");
            int solidSize = int.Parse(Console.ReadLine());
            int row = 0;

            while (row < solidSize)
            {
                int column = 0;
                while (column < solidSize)
                {
                    Console.Write("#");
                    column++;
                }
                Console.WriteLine();
                row++;
            }

            // Hollow square
            Console.WriteLine("Enter the size of the hollow square (n):");
            int hollowSize = int.Parse(Console.ReadLine());
            int currentRow = 0;

            while (currentRow < hollowSize)
            {
                int currentColumn = 0;
                while (currentColumn < hollowSize)
                {
                    // Print '#' on the borders, space inside
                    if (currentRow == 0 || currentRow == hollowSize - 1 ||
                        currentColumn == 0 || currentColumn == hollowSize - 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    currentColumn++;
                }
                Console.WriteLine();
                currentRow++;
            }
        }
    }
}