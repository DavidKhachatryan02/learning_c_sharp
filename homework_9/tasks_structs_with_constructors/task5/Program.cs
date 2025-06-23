namespace _homework_9_task_5
{
  public struct Temperature
  {
    public string City;
    public double Celsius;
    public DateTime Date;

    public Temperature(string city, double celsius, DateTime date)
    {
      City = city;
      Celsius = celsius;
      Date = date;
    }

    public void Print()
    {
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Temperature temp = new Temperature("Paris", 22.5, new DateTime(2025, 6, 16));
      Console.WriteLine($"City: {temp.City}, Temperature: {temp.Celsius}°C, Date: {temp.Date}");
    }
  }
}
