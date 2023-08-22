using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignDemo.Model
{
    internal class YellowLight:ITrafficLight
    {
        public void ChangeLight(TrafficLight trafficLight)
        {
            Console.WriteLine("Yellow Light - Prepare to stop.");
            Thread.Sleep(2000); // Simulate time passage
            trafficLight.CurrentState = new RedLight();
        }
    }
}
