namespace _homework_9_task_2
{
    public struct Circle
    {
        public double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double GetCircumference()
        {
            return 2 * Math.PI * Radius;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Area: {GetArea():F2}");
            Console.WriteLine($"Circumference: {GetCircumference():F2}");
        }
    }

    class Program
    {
        static void Main()
        {
            Circle circle = new Circle(5.0);
            circle.PrintInfo();
        }
    }
}
