using System;
using System.Collections.Generic;
using System.Text;

namespace Robots
{
    interface IRoboPart
    {
        virtual string Message { get; }
        double Consumption { get; }
        virtual double DeviceConsumption { get; protected set;}
    }
}
