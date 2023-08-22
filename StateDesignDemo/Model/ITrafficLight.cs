using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignDemo.Model
{
    internal interface ITrafficLight
    {
        void ChangeLight(TrafficLight light);
    }
}
