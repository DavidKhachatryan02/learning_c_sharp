namespace _homework_9_task_8
{
  public struct Course
  {
    public string Code;
    public string Title;
    public int Credit;

    public Course(string code, string title, int credit)
    {
      Code = code;
      Title = title;
      Credit = credit;
    }

    public void PrintInfo()
    {
      Console.WriteLine($"Course Code: {Code}, Title: {Title}, Credits: {Credit}");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Course course1 = new Course("123", "CS", 4);
      Course course2 = new Course("234", "C#endregion", 3);
      Course course3 = new Course("345", "JS", 2);

      course1.PrintInfo();
      course2.PrintInfo();
      course3.PrintInfo();
    }
  }
}