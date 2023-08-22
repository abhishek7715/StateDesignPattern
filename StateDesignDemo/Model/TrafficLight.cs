using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignDemo.Model
{
    internal class TrafficLight
    {
        public ITrafficLight CurrentState { get; set; }

        public TrafficLight()
        {
            CurrentState = new RedLight(); // Initialize with Red Light
        }

        public void Change()
        {
            CurrentState.ChangeLight(this);
        }
    }
}
