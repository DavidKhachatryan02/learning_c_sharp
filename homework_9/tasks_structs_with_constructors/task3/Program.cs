namespace _homework_9_task_3
{
    public struct Point2D
    {
        public double X;
        public double Y;

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Print()
        {
            Console.WriteLine($"Point coordinates: (X: {X}, Y: {Y})");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point2D point = new Point2D(3.5, -7.2);
            point.Print();
        }
    }
}
