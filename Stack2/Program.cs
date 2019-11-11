using System;
using System.Collections;

namespace Stack2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack my_stack = new Stack();
            my_stack.Push("lakky");
            my_stack.Push(1);
            my_stack.Push(2);
            my_stack.Push(4);
            Console.WriteLine(my_stack.Peek());
            my_stack.Pop();
            Console.WriteLine(my_stack.Peek());
            my_stack.Push(8);
            Console.WriteLine(my_stack.Peek());
        }
    }
}
