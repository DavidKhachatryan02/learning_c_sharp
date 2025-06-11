namespace _homework_8_task_1;

class Program
{
    static void Main()
    {
        int[] arr = [65, 1561, 23, 5, 54, 840, 2, 34, 7, 3, 2, 1];
        int maxNumber = int.MinValue;

        for (int i = 0; i < arr.Length; i++) {
            if (maxNumber < arr[i])
            {
                maxNumber = arr[i];
            }
        }
        Console.WriteLine($"Max number is: {maxNumber}");
    }
}
