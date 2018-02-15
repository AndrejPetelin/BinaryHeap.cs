using System;
using DataStructures;

namespace ConsoleApp2
{
    struct UserData: IComparable
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


            while (!pqueue.IsEmpty())
            {
                UserData user = pqueue.Pop();

                Console.WriteLine(user.name + " " + user.score);
            }

            Console.ReadLine();
        }
    }
}
