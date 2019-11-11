using System;
using System.Collections;
namespace Queue3
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue("lakky");
            Console.WriteLine("Number of elements in the queue are {0}" , queue.Count);
            Console.WriteLine(queue.Peek());
            queue.Enqueue(15);
            Console.WriteLine(queue.Peek());
        }
    }
}
