namespace _homework_1_task_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input any word");
            string word = Console.ReadLine();

            if (word.Length < 2)
            {
                Console.WriteLine("please write more than 2 characters long word");
            }
            else
            {
                char firstChar = word[0];
                char lastChar = word[word.Length - 1];

                char winner;

                if (firstChar < lastChar)
                {
                    winner = firstChar;
                }
                else
                {
                    winner = lastChar;
                }

                Console.WriteLine($"Between '{firstChar}' and '{lastChar}', '{winner}' wins!");
            }
        }
    }
}