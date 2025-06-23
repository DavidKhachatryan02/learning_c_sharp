namespace _homework_9_task_7
{
  public struct Rectangle
  {
    public int Width;
    public int Height;

    public Rectangle(int width, int height)
    {
      Width = width;
      Height = height;
    }

    public bool IsSquare()
    {
      return Width == Height;
    }

    public bool IsLargerThan(Rectangle other)
    {
      return GetArea() > other.GetArea();
    }

    public int GetArea()
    {
      return Width * Height;
    }

    public void PrintInfo()
    {
      Console.WriteLine($"Width: {Width}, Height: {Height}, Area: {GetArea()}, Square: {IsSquare()}");
    }
  }

  class Program
  {
    static void Main()
    {
      Rectangle r1 = new Rectangle(5, 5);
      Rectangle r2 = new Rectangle(4, 6);

      r1.PrintInfo();
      r2.PrintInfo();

      Console.WriteLine($"r1 is larger than r2: {r1.IsLargerThan(r2)}");
    }
  }
}