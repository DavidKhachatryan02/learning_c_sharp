namespace _homework_7_task_1;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int age) && age >= 0)
        {
            string group = age < 13
                ? "Child"
                : age < 18
                    ? "Teenager"
                    : age < 65
                        ? "Adult"
                        : "Senior";

            Console.WriteLine($"You are an: {group}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid non-negative number.");
        }
    }
}
