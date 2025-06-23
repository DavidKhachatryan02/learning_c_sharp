namespace _homework_9_task_5
{
  public struct DiscountCalculator
  {
    public decimal Price;
    public decimal DiscountPercentage;

    public DiscountCalculator(decimal price, decimal discountPercentage)
    {
      Price = price;
      DiscountPercentage = discountPercentage;
    }

    public decimal GetFinalPrice()
    {
      decimal discountAmount = Price * (DiscountPercentage / 100);
      return Price - discountAmount;
    }

    public void PrintFinalPrice()
    {
      Console.WriteLine($"Original Price: ${Price}");
      Console.WriteLine($"Discount: {DiscountPercentage}%");
      Console.WriteLine($"Final Price: ${GetFinalPrice():F2}");
    }
  }

  class Program
  {
    static void Main()
    {
      DiscountCalculator item = new DiscountCalculator(100m, 15m);
      item.PrintFinalPrice();
    }
  }
}