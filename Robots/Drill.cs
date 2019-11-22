using System;
using System.Collections.Generic;
using System.Text;

namespace Robots
{
    class Drill : RoboticPart, IDrill
    {
        public Drill() : this(12, 1800) { }
        public Drill(int maxSize, int maxRotations)
        {
            MaxSize = maxSize;
            MaxRotations = maxRotations;
        }

        public int MaxSize { get; protected set; }
        public int MaxRotations { get; protected set; }
        public int Size { get; protected set; }
        public int Rotations { get; protected set; }

        public override string Message => $"Drill is set up to {Size} mm and {Rotations} RPM";
    }
}

