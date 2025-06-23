namespace _homework_9_task_2
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

        public int Area()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 10);
            Console.WriteLine($"Area: {rect.Area()}");
        }
    }
}
