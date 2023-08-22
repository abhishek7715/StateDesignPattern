using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignDemo.Model
{
    internal class GreenLight:ITrafficLight
    {
        public void ChangeLight(TrafficLight trafficLight)
        {
            Console.WriteLine("Green Light - Go!");
            Thread.Sleep(2000); // Simulate time passage
            trafficLight.CurrentState = new YellowLight();
        }
    }
}
