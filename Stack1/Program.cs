using System;
using System.Collections;
namespace Stack1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack my_stack = new Stack();
            my_stack.Push("lakky");
            my_stack.Push(1234);
            my_stack.Push("G");
            my_stack.Push(45.36);
            my_stack.Push(null);
            my_stack.Push("G");

            foreach(var elem in my_stack)
            {
                Console.WriteLine(elem);
            }

        }
    }
}
