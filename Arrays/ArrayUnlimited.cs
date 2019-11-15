using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class UnlimitedArray : IDynamicArray, IEnumerable
    {
        private object[] _array;
        private readonly int _maxcnt = 10;
        public UnlimitedArray(int maxcnt=10)
        {
            _array = new object[_maxcnt];
            _maxcnt = maxcnt;

        }

        public static UnlimitedArray operator +(UnlimitedArray first, UnlimitedArray second)
        {
            UnlimitedArray result = new UnlimitedArray(first.Length + second.Length);
            uint index = 0;
            foreach (var item in first)
            {
                result.Insert(item, index++);
            }
            foreach (var item in second)
            {
                result.Insert(item, index++);
            }
            return result;
        }

        public object this[uint index]
        {
            get
            {
                return Get(index);
            }
            set
            {
                Insert(value, index);
            }
        }


        public int Count
        {
            get
            {
                int count = 0;
                for (int i = 0; i < _array.Length; i++)
                {
                    if (_array[i] != null)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public int Length
        {
            get
            {
                return _array.Length;
            }
        }

        /// <summary>
        ///   Zvětší nebo zmenší pole prvků
        /// </summary>
        /// <param name="oldArray">pole, které bude zvětšeno nebo zmenšeno</param>
        /// <param name="newSize">velikost pole po zvětšení / zmenšení</param>
        private static void ResizeArray(ref object[] oldArray, uint newSize)
        {
            object[] newArrays = new object[newSize];
            for (int i = 0; i < oldArray.Length; i++)
            {
                newArrays[i] = oldArray[i];
            }
            oldArray = newArrays;
        }

        public object Get(uint position)
        {
            return _array[position];
        }

        public void Insert(object value, uint position)
        {
            if (_array.Length <= position) { ResizeArray(ref _array, position+1); }
            if (_array[position] != null)
            {
                ShiftItems(position);
            }
            _array[position] = value;
        }

        public void ShiftItems(uint idexFrom)
        {
            for (uint i = (uint)_array.Length; i > idexFrom; i--)
            {
                if (_array.Length == i)
                {
                    ResizeArray(ref _array, (uint)_array.Length + 1);
                }
                _array[i] = _array[i-1];
            }
        }
        public IEnumerator GetEnumerator()
        {
            foreach (var item in _array)
            {
                if (!(item is null)) yield return item;
            }
        }

        public object Get(int position)
        {
            throw new NotImplementedException();
        }

        public object[] GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(object value)
        {
            throw new NotImplementedException();
        }
    }
}