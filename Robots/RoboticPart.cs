using System;
using System.Collections.Generic;
using System.Text;

namespace Robots
{
    class RoboticPart : IRoboPart
    {
        public double Consumption => throw new NotImplementedException();

        public string Message => throw new NotImplementedException();

        public double DeviceConsumption { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
