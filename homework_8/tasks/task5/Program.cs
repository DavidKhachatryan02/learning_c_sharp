namespace _homework_8_task_5
{
  public class Program
  {
    static void Main(string[] args)
    {
      string[] fruits = ["apple", "pear", "watermelons"];

      Console.WriteLine("Write frout to find: ");
      string? userInput = Console.ReadLine();

      if (!string.IsNullOrEmpty(userInput))
      {
        int foundFruit = Array.IndexOf(fruits, userInput);
        if (foundFruit == -1)
        {
          Console.WriteLine("Not found");
        }
        else
        {
          Console.WriteLine("fruit find");
        }
      }
      else
      {
        Console.WriteLine("Invalid inpit");
      }
    }
  }
}
