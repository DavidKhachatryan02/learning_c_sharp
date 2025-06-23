namespace _homework_9_task_2
{
    public enum TrafficLight
    {
        Red,
        Yellow,
        Green
    }

    public struct Intersection
    {
        public string Name;
        public TrafficLight CurrentLight;

        public Intersection(string name, TrafficLight initialLight)
        {
            Name = name;
            CurrentLight = initialLight;
        }

        public void PrintStatus()
        {
            Console.WriteLine($"Intersection: {Name}, Current Light: {CurrentLight}");
        }

        public void CycleLight()
        {
            // Change to the next light
            switch (CurrentLight)
            {
                case TrafficLight.Red:
                    CurrentLight = TrafficLight.Green;
                    break;
                case TrafficLight.Green:
                    CurrentLight = TrafficLight.Yellow;
                    break;
                case TrafficLight.Yellow:
                    CurrentLight = TrafficLight.Red;
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Intersection mainStreet = new Intersection("Street", TrafficLight.Red);

            for (int i = 0; i < 6; i++)
            {
                mainStreet.PrintStatus();
                mainStreet.CycleLight();
            }
        }
    }
}
