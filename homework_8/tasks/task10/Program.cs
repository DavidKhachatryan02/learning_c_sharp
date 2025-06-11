namespace _homework_8_task_10
{
  public class Program
  {
    static void Main(string[] args)
    {
      int[] numbers = [1, 1, 1, 2, 3, 3, 4, 4, 4, 4, 1, 2];

      Array.Sort(numbers);
      int currentNumber = numbers[0];
      int count = 1;

      for (int i = 1; i < numbers.Length; i++)
      {
        System.Console.WriteLine(currentNumber);
        if (numbers[i] == currentNumber)
        {
          System.Console.WriteLine(numbers[i]);
          count++;
        }
        else
        {
          Console.WriteLine($"Number {currentNumber} appears {count} times.");
          currentNumber = numbers[i];
          count = 1;
        }
      }
      Console.WriteLine($"Number {currentNumber} appears {count} times.");
    }
  }
}
