namespace _homework_9_task_9
{
  public struct Voter
  {
    public int Age;
    public Voter(int age)
    {
      Age = age;
    }

    public bool CanVote()
    {
      return Age >= 18;
    }

    public void PrintEligibility()
    {
      Console.WriteLine($"Age: {Age}");
      Console.WriteLine(CanVote() ? "Eligible to vote." : "Not eligible to vote.");
    }
  }

  class Program
  {
    static void Main()
    {
      Voter voter1 = new Voter(20);
      Voter voter2 = new Voter(16);

      voter1.PrintEligibility();
      voter2.PrintEligibility();
    }
  }
}
