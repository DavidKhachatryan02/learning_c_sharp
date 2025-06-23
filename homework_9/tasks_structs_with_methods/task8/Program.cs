namespace _homework_9_task_8
{
  public struct Temperature
  {
    public double Celsius;

    public Temperature(double celsius)
    {
      Celsius = celsius;
    }

    public double ToFahrenheit()
    {
      return (Celsius * 9 / 5) + 32;
    }

    public double ToKelvin()
    {
      return Celsius + 273.15;
    }

    public void PrintConversions()
    {
      Console.WriteLine($"Celsius: {Celsius}°C");
      Console.WriteLine($"Fahrenheit: {ToFahrenheit():F2}°F");
      Console.WriteLine($"Kelvin: {ToKelvin():F2}K");
    }
  }

  class Program
  {
    static void Main()
    {
      Temperature temp = new Temperature(25);
      temp.PrintConversions();
    }
  }
}
