namespace _homework_9_task_6
{
  public struct TimeInterval
  {
    public DateTime StartTime;
    public DateTime EndTime;

    public TimeInterval(DateTime startTime, DateTime endTime)
    {
      StartTime = startTime;
      EndTime = endTime;
    }

    public TimeSpan GetDuration()
    {
      return EndTime - StartTime;
    }

    public void PrintDuration()
    {
      Console.WriteLine($"Start: {StartTime}");
      Console.WriteLine($"End:   {EndTime}");
      Console.WriteLine($"Duration: {GetDuration()}");
    }
  }

  class Program
  {
    static void Main()
    {
      DateTime start = new DateTime(2025, 6, 21, 9, 30, 0);
      DateTime end = new DateTime(2025, 6, 21, 14, 45, 0);

      TimeInterval interval = new TimeInterval(start, end);
      interval.PrintDuration();
    }
  }
}
