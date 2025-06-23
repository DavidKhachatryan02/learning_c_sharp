namespace _homework_9_task_8
{
  public enum ProductCategory
  {
    Electronics,
    Clothing,
    Food,
    Tools
  }

  public struct Product
  {
    public string Name;
    public ProductCategory Category;
    public int Quantity;

    public Product(string name, ProductCategory category, int quantity)
    {
      Name = name;
      Category = category;
      Quantity = quantity;
    }
  }

  class Program
  {
    static void Main()
    {
      // Sample product inventory
      Product[] products = new Product[]
      {
                new Product("Laptop", ProductCategory.Electronics, 5),
                new Product("T-shirt", ProductCategory.Clothing, 20),
                new Product("Hammer", ProductCategory.Tools, 7),
                new Product("Bread", ProductCategory.Food, 15),
                new Product("Smartphone", ProductCategory.Electronics, 3),
                new Product("Jeans", ProductCategory.Clothing, 10)
      };

      // Counters for each category
      int electronicsTotal = 0;
      int clothingTotal = 0;
      int foodTotal = 0;
      int toolsTotal = 0;

      // Count total items per category
      for (int i = 0; i<products.Length; i++)
      {
        switch (products[i].Category)
        {
          case ProductCategory.Electronics:
            electronicsTotal += products[i].Quantity;
            break;
          case ProductCategory.Clothing:
            clothingTotal += products[i].Quantity;
            break;
          case ProductCategory.Food:
            foodTotal += products[i].Quantity;
            break;
          case ProductCategory.Tools:
            toolsTotal += products[i].Quantity;
            break;
        }
      }

      // Output results
      Console.WriteLine("Total Items by Category:");
      Console.WriteLine($"Electronics: {electronicsTotal}");
      Console.WriteLine($"Clothing: {clothingTotal}");
      Console.WriteLine($"Food: {foodTotal}");
      Console.WriteLine($"Tools: {toolsTotal}");
    }
  }
}
