namespace _homework_8_task_7
{
  public class Program
  {
    static void Main(string[] args)
    {
      int[] numbers = [17, 4, 1, 5];
      int sum = 0;

      for (int i = 0; i < numbers.Length; i++)
      {
        sum += numbers[i];
      }
      Console.WriteLine($"sum: {sum}");
    }
  }
}
