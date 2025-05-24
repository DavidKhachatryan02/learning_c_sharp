using System;
using User_Task_5;
namespace _homework_7_task_5
{
  public class Program
  {
    static void Main(string[] args)
    {
      var user1Profile = new Profile("This is a bio");
      var user1 = new User(user1Profile);

      var user2 = new User(new Profile("This is a bio"));

      var user3 = new User(new Profile());
      var user4 = new User();

      Console.WriteLine(user1?.Profile?.Bio ?? "No bio set");
      Console.WriteLine(user2?.Profile?.Bio ?? "No bio set");
      Console.WriteLine(user3?.Profile?.Bio ?? "No bio set");
      Console.WriteLine(user4?.Profile?.Bio ?? "No bio set");
    }
  }
}
