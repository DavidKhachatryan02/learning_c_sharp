namespace _homework_9_task_7
{
  public enum AccountType
  {
    Checking,
    Savings,
    Business
  }

  public struct Account
  {
    public string Holder;
    public AccountType Type;
    public decimal Balance;

    public Account(string holder, AccountType type, decimal balance)
    {
      Holder = holder;
      Type = type;
      Balance = balance;
    }

    public void PrintInfo()
    {
      Console.WriteLine($"Holder: {Holder}, Type: {Type}, Balance: ${Balance:F2}");
    }
  }

  class Program
  {
    static void Main()
    {
      // Create 3 bank accounts
      Account[] accounts =
      [
          new Account("Alice Johnson", AccountType.Checking, 1200.50m),
          new Account("Bob Smith", AccountType.Savings, 3400.75m),
          new Account("Carla Gomez", AccountType.Business, 8750.00m)
      ];

      decimal totalBalance = 0;

      Console.WriteLine("Account List:");
      for (int i = 0; i < accounts.Length; i++)
      {
        accounts[i].PrintInfo();
        totalBalance += accounts[i].Balance;
      }

      Console.WriteLine($"\nTotal Balance: ${totalBalance:F2}");
    }
  }
}
