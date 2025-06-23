namespace _homework_9_task_6
{
  public enum FuelType
  {
    Petrol,
    Diesel,
    Electric,
    Hybrid
  }

  public struct Vehicle
  {
    public string License;
    public FuelType Fuel;
    public int Year;

    public Vehicle(string license, FuelType fuel, int year)
    {
      License = license;
      Fuel = fuel;
      Year = year;
    }

    public void PrintInfo()
    {
      Console.WriteLine($"License: {License}, Fuel: {Fuel}, Year: {Year}");
    }
  }

  class Program
  {
    static void Main()
    {
      // Create 5 vehicles
      Vehicle[] vehicles =
      [
          new Vehicle("ABC-123", FuelType.Petrol, 2018),
                new Vehicle("XYZ-789", FuelType.Electric, 2022),
                new Vehicle("JKL-456", FuelType.Diesel, 2016),
                new Vehicle("MNO-111", FuelType.Hybrid, 2020),
                new Vehicle("DEF-222", FuelType.Petrol, 2019)
      ];
    }
  }
}
