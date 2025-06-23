namespace _homework_9_task_9
{
  public enum BloodType
  {
    A,
    B,
    AB,
    O
  }

  public struct Patient
  {
    public string Name;
    public BloodType Type;
    public bool RhPositive;

    public Patient(string name, BloodType type, bool rhPositive)
    {
      Name = name;
      Type = type;
      RhPositive = rhPositive;
    }
  }

  class Program
  {
    static void Main()
    {
      Patient[] patients =
      [
                new Patient("Alice", BloodType.A, true),
                new Patient("Bob", BloodType.O, false),
                new Patient("Clara", BloodType.B, true),
                new Patient("David", BloodType.AB, false),
                new Patient("Eva", BloodType.O, true),
                new Patient("Frank", BloodType.B, false),
                new Patient("Grace", BloodType.A, false),
      ];

      int aPos = 0, aNeg = 0;
      int bPos = 0, bNeg = 0;
      int abPos = 0, abNeg = 0;
      int oPos = 0, oNeg = 0;

      for (int i = 0; i < patients.Length; i++)
      {
        var p = patients[i];

        if (p.Type == BloodType.A)
          if (p.RhPositive) aPos++; else aNeg++;

        else if (p.Type == BloodType.B)
          if (p.RhPositive) bPos++; else bNeg++;

        else if (p.Type == BloodType.AB)
          if (p.RhPositive) abPos++; else abNeg++;

        else if (p.Type == BloodType.O)
          if (p.RhPositive) oPos++; else oNeg++;
      }

      Console.WriteLine("Patient Groups by Blood Type and Rh Factor:");
      Console.WriteLine($"A+: {aPos}, A-: {aNeg}");
      Console.WriteLine($"B+: {bPos}, B-: {bNeg}");
      Console.WriteLine($"AB+: {abPos}, AB-: {abNeg}");
      Console.WriteLine($"O+: {oPos}, O-: {oNeg}");
    }
  }
}
