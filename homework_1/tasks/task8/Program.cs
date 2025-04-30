namespace _homework_1_task_8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write word");
            string inputWord = Console.ReadLine();
            
            string middlePart = inputWord.Substring(1, inputWord.Length - 2);

            Console.WriteLine(inputWord[inputWord.Length-1]+middlePart+inputWord[0]);
        }
    }
}