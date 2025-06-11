namespace _homework_8_task_9
{
  public class Program
  {
    static void Main(string[] args)
    {
      string[] names = ["Davit", "Gago", "John"];
      string[] surnames = ["Khachatryan", "Sasunci", "Doe"];

      for (int i = 0; i < names.Length; i++)
      {
        Console.WriteLine($"{names[i]} {surnames[i]}");
      }
    }
  }
}
