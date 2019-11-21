using System;
using System.Collections.Generic;
using System.Text;

namespace Robots
{
    class BasicRoboChasis : RoboticPart
    {
        public BasicRoboChasis(string name = "základní tělo", double battery = 1000, double consumption = 20)
        {
            Name = name;
            DeviceConsumption = consumption;
            MaxBattery = battery;
        }
        public string Name { get; }
        protected RoboArm Arm { get; set; }
        public double MaxBattery { get; }





        public void Install(RoboArm tool)
        {
            Arm = tool;
        }
    }
}
