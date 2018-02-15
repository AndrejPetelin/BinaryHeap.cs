using System;
using DataStructures;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 2, 3, 4, 1, 8, 12, 234, -15, 371, 8, 8, 8 };
            BinaryHeap<int> pqueue = new BinaryHeap<int>((x, y) => { return y.CompareTo(x); });

            foreach (int i in array)
            {
                pqueue.Push(i);
            }

            while (!pqueue.IsEmpty())
            {
                Console.WriteLine(pqueue.Pop());
            }

            try
            {
                int n = pqueue.Pop();
                Console.WriteLine(n);
            }
            catch(SystemException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
