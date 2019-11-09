using System;

namespace String3
{
    class Program
    {
        static void Main(string[] args)
        {
            String s1 = "India is my Country";
            String s2 = s1;
            s1 += "world";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
