namespace _homework_9_task_9
{

  public struct Location
  {
    public double Latitude { get; private set; }
    public double Longitude { get; private set; }

    public Location(double latitude, double longitude)
    {
      if (latitude < -90 || latitude > 90)
      {
        Console.WriteLine("Invalid latitude! Must be between -90 and 90.");
      }
      else
      {
        Latitude = latitude;
      }

      if (longitude < -180 || longitude > 180)
      {
        Console.WriteLine("Invalid longitude! Must be between -180 and 180.");
      }
      else
      {
        Longitude = longitude;
      }
    }

    public void Print()
    {
      Console.WriteLine($"Latitude: {Latitude}, Longitude: {Longitude}");
    }
  }

  class Program
  {
    static void Main()
    {
      Location loc1 = new Location(40.7128, -74.0060);
      loc1.Print();

      Location loc2 = new Location(95, 200);
      loc2.Print();
    }
  }
}