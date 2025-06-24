public class Project
{
    public string Title { get; set; }
    public decimal Fee { get; set; }
    public bool IsCompleted { get; set; }

    public Project(string title, decimal fee, bool isCompleted = false)
    {
        Title = title;
        Fee = fee;
        IsCompleted = isCompleted;
    }
}
