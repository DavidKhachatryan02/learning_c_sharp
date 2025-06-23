namespace _homework_9_task_6
{
  using System;

  public struct Gadget
  {
    public string Name;
    public string Brand;
    public decimal Price;
    public int Quantity;

    public Gadget(string name, string brand, decimal price, int quantity)
    {
      Name = name;
      Brand = brand;
      Price = price;
      Quantity = quantity;
    }

    public void PrintInfo()
    {
      Console.WriteLine($"Gadget: {Name}, Brand: {Brand}, Price: ${Price}, Quantity: {Quantity}");
    }
  }
}
