namespace _homework_9_task_1
{
    public struct Book
    {
        public string Title;
        public string Author;
        public int Year;

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Title} by {Author} ({Year})");
        }
        class Program
        {
            static void Main(string[] args)
            {
                var book = new Book("Book", "Tumanyan", 1952);
                book.PrintInfo();
            }
        }
    }
}
