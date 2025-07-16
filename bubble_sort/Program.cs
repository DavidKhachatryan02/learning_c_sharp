namespace bubble_sort
{
    public class Program
    {
        static void Main()
        {
            int[] array = [5, 8, 6, 1, 2, 3];

            BubbleSortArr(array);

            Console.WriteLine(String.Join(',', array));
        }
        static void BubbleSortArr(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        swapped = true;

                        int tempValue = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tempValue;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
            return;
        }
    }
}