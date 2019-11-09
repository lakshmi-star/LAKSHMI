using System;

namespace String8
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 15;
            String fname = "mango";
            String fcolor = "yellow";

            String str = String.Format("{0} {1} fruits are in {2} color", number.ToString(), fname, fcolor);
            Console.WriteLine("str");
        }
    }
}
