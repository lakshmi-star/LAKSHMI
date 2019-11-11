using System;
using System.Collections;
namespace Queue2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue("four");
            Console.WriteLine("Number of elements in the queue are {0}" , queue.Count);

            while(queue.Count > 0)
            
                Console.WriteLine(queue.Dequeue());
            Console.WriteLine("The Number of elements in the queue are {0}", queue.Count);
        }
    }
}
