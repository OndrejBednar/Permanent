using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public interface IDynamicArray<T>
    {
        T Get(int position);
        T[] GetAll();
        void Insert(T value, uint position);
        void ShiftItems(uint idexFrom);
        void Add(T value);
        int Count { get; }
        int Length { get; }
    }
}