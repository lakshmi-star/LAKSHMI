using System;
using System.Collections;
namespace Stack4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push("lakky");
            myStack.Push(1);
            myStack.Push(6);
            myStack.Push("avula");
            Console.WriteLine(myStack.Contains(1));
            Console.WriteLine(myStack.Contains("royal"));
        }
    }
}
