using System;
using System.Collections;

namespace Stack3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack my_stack = new Stack();
            my_stack.Push("lakky");
            my_stack.Push(1);
            my_stack.Push(5);
            my_stack.Push("avula");
            Console.WriteLine("Total no. of elements is : {0}", my_stack.Count);
            while(my_stack.Count > 0)
           
               Console.WriteLine(my_stack.Pop());
                Console.WriteLine("Total no. of elements is : {0}", my_stack.Count);
                
           
        }
    }
}
