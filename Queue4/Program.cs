using System;
using System.Collections;
namespace Queue4
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue qt = new Queue();
            qt.Enqueue(1);
            qt.Enqueue(2);
            qt.Enqueue(3);
            qt.Enqueue("fifteen");
            Console.WriteLine("Number of elements in the queue are {0}", qt.Count);
            foreach (var i in qt.ToArray())
            {
                Console.WriteLine(i);
            }
        }
    }
}
