namespace _homework_1_task_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write 6 characters long word");
            string word = Console.ReadLine();
            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine("Please enter a word.");
                return;
            }
            if (word.Length != 6)
            {
                Console.WriteLine("Please enter a word that is exactly 6 characters long.");
                return;
            }

            // Console.WriteLine(string.Concat(new[] { word[1], word[3], word[5] }));

            char secondChar = word[1];
            char fourthChar = word[3];
            char sixthChar = word[5];

            Console.WriteLine($"{secondChar}{fourthChar}{sixthChar}");
        }
    }
}