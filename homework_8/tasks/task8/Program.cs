namespace _homework_8_task_8
{
  public class Program
  {
    static void Main(string[] args)
    {
      int[] numbers = [17, 4, 1, 5, 16];
      int[] resultArr = new int[numbers.Length];

      for (int i = 0; i < numbers.Length; i++)
      {
        resultArr[i] = numbers[i];
      }
      Console.WriteLine($"{string.Join(',', resultArr)}");
    }
  }
}
