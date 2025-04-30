namespace _homework_1_task_7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write word with even number of characters");
            string word = Console.ReadLine();
            if (word.Length % 2 != 0)
            {
                Console.WriteLine("Error: The word must have an even number of letters!");
                return;
            }
            
            int middleIndex = word.Length / 2;
            string firstHalf = word.Substring(0, middleIndex);
            string secondHalf = word.Substring(middleIndex);

            Console.WriteLine(firstHalf);
            Console.WriteLine(secondHalf);
        }
    }
}