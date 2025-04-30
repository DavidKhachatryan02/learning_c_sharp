namespace _homework_1_task_9
{
    public class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("write first character");
            char firstChar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("write second character");
            char secondChar = Convert.ToChar(Console.ReadLine());

            int unicode1 = firstChar;
            int unicode2 = secondChar;

            int difference = unicode1 - unicode2;
            
            Console.WriteLine($"{firstChar}: {unicode1}, {secondChar}: {unicode2}, difference: {difference}");
        }
    }
}