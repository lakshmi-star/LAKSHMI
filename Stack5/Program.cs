using System;
using System.Collections;
namespace Stack5
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack my_stack = new Stack();
            my_stack.Push(1);
            my_stack.Push(2);
            my_stack.Push(3);
            my_stack.Push(5);

            my_stack.Clear();

            Console.WriteLine("Number of elements is {0}", my_stack.Count);
        }
    }
}
