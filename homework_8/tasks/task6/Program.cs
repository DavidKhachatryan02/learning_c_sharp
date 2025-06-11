namespace _homework_8_task_6
{
  public class Program
  {
    static void Main(string[] args)
    {
      int[] numbers = [17, 4, 1, 5];
      int arrLength = numbers.Length;

      for (int i = 0; i < arrLength; i++)
      {
        for (int j = i + 1; j < arrLength; j++)
        {
          if (numbers[i] > numbers[j])
          {
            int numberToChange = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = numberToChange;
          }
        }
      }
      Console.WriteLine(string.Join(',', numbers));
    }
  }
}
