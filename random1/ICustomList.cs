﻿using System;
using System.Collections.Generic;
using System.Text;

namespace random1
{
    interface ICustomList
    {
        void Add(Grade g);
        bool Insert(GradeAvg g, int position);
        bool Delete(GradeAvg g);
        bool Delete(int position);
        GradeAvg Get(int position);
        GradeAvg[] GetAll();
        int IndexOf(GradeAvg g);
        int IndexOf(string subject);
        int Count { get; }
        int Length { get; }
    }
}
