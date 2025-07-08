namespace _homework_12
{
  class Program
  {
    static void Main()
    {
      var sight1 = new Sight("Hraparal", "15x", "16y");
      var sight2 = new Sight("kaskad", "25x", "34y");
      var sight3 = new Sight("opera", "55x", "46y");

      var sights = new List<Sight> { sight1, sight2, sight3 };

      var cityWithoutEnumirator = new CityWithoutEnumirator("Yerevan", sights);

      foreach (var sight in cityWithoutEnumirator)
      {
        Console.WriteLine($"{sight.Name}, {sight.CordinateX}, {sight.CordinateY}");
      }

      var cityWithEnumerator = new CityWithEnumerator("Gyumri", sights);
      foreach (var sight in cityWithEnumerator)
      {
        Console.WriteLine($"{sight.Name}, {sight.CordinateX}, {sight.CordinateY}");
      }
    }
  }
}