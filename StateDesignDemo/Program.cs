using StateDesignDemo.Model;

namespace StateDesignDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrafficLight trafficLight = new TrafficLight();

            while (true)
            {
                trafficLight.Change();
            }
        }
    }
}