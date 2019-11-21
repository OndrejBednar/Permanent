using System;
using System.Collections.Generic;
using System.Text;

namespace Robots
{
    class Drill : RoboticPart, IDrill
    {
        const double DrillCovGalacticConstant = 0.4;

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
        public int SetSize(int size) { Size = (size < MaxSize) ? size : MaxSize; return Size; }
        public int SetRotations(int rotations) { Rotations = (rotations < MaxRotations) ? rotations : MaxRotations; return Rotations; }

        public override string Message => $"Drill set up to {Size} mm and {Rotations} RPM";
    }
}

