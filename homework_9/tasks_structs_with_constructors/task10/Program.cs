namespace _homework_9_task_10
{

  public struct User
  {
    public string Username { get; }
    public string Email { get; }
    public DateTime CreatedAt { get; }

    public User(string username, string email)
    {
      Username = username;
      Email = email;
      CreatedAt = DateTime.Now;
    }

    public void Print()
    {
      Console.WriteLine($"Username: {Username}, Email: {Email}, CreatedAt: {CreatedAt}");
    }
  }

  class Program
  {
    static void Main()
    {
      User user = new User("davit123", "davit@example.com");
      user.Print();
    }
  }
}