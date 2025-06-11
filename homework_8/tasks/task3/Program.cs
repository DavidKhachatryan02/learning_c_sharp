namespace _homework_8_task_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            double[] examScores = [0.45, 1.547, 10.42, 19];
            double examScoresSum = 0;
            for (int i = 0; i < examScores.Length; i++)
            {
                examScoresSum += examScores[i];
            }

            Console.WriteLine(examScoresSum / examScores.Length);
        }
    }
}