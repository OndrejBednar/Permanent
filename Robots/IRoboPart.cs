using System;
using System.Collections.Generic;
using System.Text;

namespace Robots
{
    interface IRoboPart
    {
        string Message { get; }
        double Consumption { get; }
        double DeviceConsumption { get; set;}
    }
}
