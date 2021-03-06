﻿using System;
using System.Collections.Generic;
using System.Text;

namespace random1
{
    class GradeAvg : Grade
    {
        public int Count;

        public GradeAvg(string subject)
        {
            this.Subject = subject;
        }

        public double GetAverage()
        {
            return Score / Count;
        }

        public bool AddGrade(Grade grade)
        {
            if (grade.Subject != Subject) return false;

            Score += grade.Score;
            Count += 1;
            return true;
        }

        public override string ToString()
        {
            return Subject + ": " + Math.Round(GetAverage(), 1);
        }
    }
}