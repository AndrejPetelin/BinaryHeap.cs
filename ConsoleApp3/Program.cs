using System;
using DataStructures;

namespace ConsoleApp3
{
    struct UserData : IComparable
    {
        public UserData(string n, int s) { name = n; score = s; }
        public string name;
        public int score;

        public int CompareTo(object obj)
        {
            UserData? ud = obj as UserData?;
            return score.CompareTo(ud?.score);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            BinaryHeap<UserData> pqueue = new BinaryHeap<UserData>();

            for (int i = 0; i < 30; ++i)
            {
                Random r = new Random();
                pqueue.Push(new UserData("abc", r.Next()));

            }

            UserData[] popTen = pqueue.Pop(10);

            foreach (var user in popTen)
            {
                Console.WriteLine(user.name + " " + user.score);
            }

            Console.WriteLine();

            UserData[] peekRest = pqueue.PeekAll();

            foreach(var user in peekRest)
            { 
                Console.WriteLine(user.name + " " + user.score);
            }

            Console.WriteLine();


            UserData[] popAll = pqueue.PopAll();

            foreach(var user in popAll)
            {
                Console.WriteLine(user.name + " " + user.score);
            }

            Console.ReadLine();
        }
    }
}
