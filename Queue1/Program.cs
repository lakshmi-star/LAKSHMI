using System;
using System.Collections;

namespace Queue1
{
    class Program
    {
         public static void Main()
        {
            Queue queue = new Queue();
            queue.Enqueue("lakky");
            queue.Enqueue("nandu");
            queue.Enqueue("lavanya");

            Console.WriteLine("Number of elements in the queue are  "+ queue.Count);
           
        }
           
    }
}
