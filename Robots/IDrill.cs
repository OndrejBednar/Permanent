using System;
using System.Collections.Generic;
using System.Text;

namespace Robots
{
    public interface IDrill
    {
        int MaxSize { get; }
        int MaxRotations { get; }
        int Size { get; }
        int Rotations { get; }
    }
}
