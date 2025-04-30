namespace _homework_1_task_6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write any word");
            string word = Console.ReadLine();
            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine("Please enter a word.");
                return;
            }

            Console.WriteLine(word.ToUpper()+word.ToLower());
            
            string upper = word.ToUpper();
            string lower = word.ToLower();
            string result = string.Concat(upper, lower);

            Console.WriteLine(result);
        }
    }
}