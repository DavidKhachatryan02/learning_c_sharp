namespace _homework_9_task_10
{
  public struct Invoice
  {
    public decimal UnitPrice;
    public int Quantity;

    public Invoice(decimal unitPrice, int quantity)
    {
      UnitPrice = unitPrice;
      Quantity = quantity;
    }
    public decimal GetTotal()
    {
      return UnitPrice * Quantity;
    }
    public void PrintInvoice()
    {
      Console.WriteLine($"Unit Price: ${UnitPrice}");
      Console.WriteLine($"Quantity: {Quantity}");
      Console.WriteLine($"Total: ${GetTotal()}");
    }
  }

  class Program
  {
    static void Main()
    {
      Invoice invoice = new Invoice(19.99m, 3);
      invoice.PrintInvoice();
    }
  }
}
