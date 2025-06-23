namespace _homework_9_task_1
{
    public enum DayOfWeek
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    public struct Schedule
    {
        public DayOfWeek Day;
        public string Task;

        public Schedule(DayOfWeek day, string task)
        {
            Day = day;
            Task = task;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Schedule schedule1 = new Schedule(DayOfWeek.Monday, "Team Meeting");
            Schedule schedule2 = new Schedule(DayOfWeek.Wednesday, "Project Work");
            Schedule schedule3 = new Schedule(DayOfWeek.Friday, "Code Review");

            Console.WriteLine($"Day: {schedule1.Day}, Task: {schedule1.Task}");
            Console.WriteLine($"Day: {schedule2.Day}, Task: {schedule2.Task}");
            Console.WriteLine($"Day: {schedule3.Day}, Task: {schedule3.Task}");
        }
    }
}
