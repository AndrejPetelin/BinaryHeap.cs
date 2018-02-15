using System;
using System.Collections.Generic;


namespace DataStructures
{
    public delegate int Compare(IComparable x, IComparable y);

    public class BinaryHeap<T> where T:IComparable
    {
        Compare comp;
        List<T> data = new List<T>();

        public int Size { get { return data.Count; } private set { } }
        public bool IsEmpty() { return data.Count == 0;  }

        public BinaryHeap() { comp = (x, y) => { return x.CompareTo(y); }; }

        public BinaryHeap(Compare compareTo) { comp = compareTo; }

        public void Push(T x)
        {
            data.Add(x);
            int index = Size - 1;

            while (index > 0)
            {
                int parent = ParentIndex(index);

                if (comp(data[index], data[parent]) < 0)
                {
                    SwapAt(index, parent);
                    index = parent;
                }
                else
                {
                    break;
                }
            }
        }


        public T Pop()
        {
            if (IsEmpty()) throw new System.IndexOutOfRangeException("Called Pop() on empty BinaryHeap");

            T ret = data[0];
            int index = 0;

            SwapAt(0, Size - 1);
            data.RemoveAt(Size - 1);

            while (index < Size)
            {
                int childIndex = MinChildIndex(index);
                
                if (childIndex >= 0 && comp(data[childIndex], data[index]) < 0)
                {
                    SwapAt(index, childIndex);
                    index = childIndex;
                }
                else
                {
                    break;
                }
            }

            return ret;
        }


        int ParentIndex(int i)
        {
            return (i + 1) / 2 - 1;
        }


        int MinChildIndex(int i)
        {
            int childR = (i + 1) * 2;
            int childL = childR - 1;

            if (childL >= Size) return -1;
            else if (childR < Size && comp(data[childR], data[childL]) < 0) return childR;
            else return childL;
        }


        void SwapAt(int i, int j)
        {
            T temp = data[i];
            data[i] = data[j];
            data[j] = temp;
        }
    }
}