namespace _homework_8_task_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            int oddCount = 0;
            int evenCount = 0;
            int[] arr = [65, 1561, 23, 5, 54, 840, 2, 34, 7, 3, 2];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;

                }
            }

            Console.WriteLine($"Odd: {oddCount}, Even: {evenCount}");
        }
    }
}