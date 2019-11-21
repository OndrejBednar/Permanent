using System;
using System.Collections.Generic;
using System.Text;

namespace Robots
{
    interface IRoboPartConsumption
    {
        double Consumption { get; }
        double DeviceConsumption { get;set;}
    }
}
