using System.Text;
namespace _homework_6_task_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee name:");
            string employeeName = Console.ReadLine();
            Console.WriteLine("Enter day of the week (1-7):");
            int dayOfWeek = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter shift start time (0-23):");
            int shiftStart = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter shift end time (0-23):");
            int shiftEnd = int.Parse(Console.ReadLine());
            if (shiftStart < 0 || shiftStart > 23 || shiftEnd < 0 || shiftEnd > 23)
            {
                Console.WriteLine("Invalid time input. Please enter times in 24-hour format (0-23).");
                return;
            }
            if (shiftEnd - shiftStart > 12)
            {
                Console.WriteLine("Warning: Shift is longer than 12 hours.");
            }
             string shiftType;
            if (shiftStart < 12)
            {
                shiftType = "Morning";
            }
            else if (shiftStart < 18)
            {
                shiftType = "Afternoon";
            }
            else
            {
                shiftType = "Night";
            }
            string shiftLength = (shiftEnd - shiftStart > 8) ? "Long" : "Short";
            
            StringBuilder summary = new StringBuilder();
            summary.AppendLine($"Employee Name: {employeeName}");
            summary.AppendLine($"Day of Work: {dayOfWeek}");
            summary.AppendLine($"Shift Start: {shiftStart}");
            summary.AppendLine($"Shift End: {shiftEnd}");
            summary.AppendLine($"Shift type: {shiftType}");
            summary.AppendLine($"Shift Length: {shiftLength}");
            Console.WriteLine(summary.ToString());

        }
    }
}