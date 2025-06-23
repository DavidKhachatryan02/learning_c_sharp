namespace _homework_9_task_5
{
  public enum BulbState
  {
    On,
    Off,
    Broken
  }

  public struct LightBulb
  {
    public string Room;
    public BulbState State;
    public int Wattage;

    public LightBulb(string room, BulbState state, int wattage)
    {
      Room = room;
      State = state;
      Wattage = wattage;
    }

    public void PrintInfo()
    {
      Console.WriteLine($"Room: {Room}, State: {State}, Wattage: {Wattage}W");
    }
  }

  class Program
  {
    static void Main()
    {
      // Create an inventory of bulbs
      LightBulb[] bulbs = new LightBulb[]
      {
                new LightBulb("Living Room", BulbState.On, 60),
                new LightBulb("Kitchen", BulbState.Off, 75),
                new LightBulb("Bedroom", BulbState.Broken, 40),
                new LightBulb("Bathroom", BulbState.Off, 60)
      };

      Console.WriteLine("Light Bulb Inventory:");
      foreach (var bulb in bulbs)
      {
        bulb.PrintInfo();
      }
    }
  }
}
