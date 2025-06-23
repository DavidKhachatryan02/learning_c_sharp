namespace _homework_9_task_4
{
    public enum WeatherType
    {
        Sunny,
        Rainy,
        Cloudy,
        Stormy,
        Snowy
    }

    public struct WeatherReport
    {
        public string City;
        public WeatherType Weather;
        public int Temperature;

        public WeatherReport(string city, WeatherType weather, int temperature)
        {
            City = city;
            Weather = weather;
            Temperature = temperature;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WeatherReport report1 = new WeatherReport("Yerevan", WeatherType.Sunny, 32);
            WeatherReport report2 = new WeatherReport("London", WeatherType.Rainy, 18);
            WeatherReport report3 = new WeatherReport("Moscow", WeatherType.Snowy, -5);

            Console.WriteLine($"City: {report1.City}, Weather: {report1.Weather}, Temperature: {report1.Temperature}°C");
            Console.WriteLine($"City: {report2.City}, Weather: {report2.Weather}, Temperature: {report2.Temperature}°C");
            Console.WriteLine($"City: {report3.City}, Weather: {report3.Weather}, Temperature: {report3.Temperature}°C");
        }
    }
}
