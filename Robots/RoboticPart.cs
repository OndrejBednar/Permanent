using System;
using System.Collections.Generic;
using System.Text;

namespace Robots
{
    abstract class RoboticPart : IRoboPartConsumption
    {
        public virtual string Message => "General robotic part";
        public double Consumption => DeviceConsumption;
        public double DeviceConsumption { get;protected set; }
    }
}
