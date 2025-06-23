namespace _homework_9_task_7
{
  public struct Transaction
  {
    public int Id;
    public decimal Amount;
    public DateTime Timestamp;

    public Transaction(int id, decimal amount)
    {
      Id = id;
      Amount = amount;
      Timestamp = DateTime.Now;
    }

    public void Print()
    {
      Console.WriteLine($"ID: {Id}, Amount: ${Amount}, Timestamp: {Timestamp}");
    }
  }
}
