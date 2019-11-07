using System;

namespace Function2
{
    class Program
    {
        public void show(int val)
        {
            val *= val;
            Console.WriteLine("value inside the function" + val);
        }
        static void Main(string[] args)
        {
            int val = 50;
            Program p = new Program();
            Console.WriteLine("before calling the function" + val);
            p.show(val);
            Console.WriteLine("after calling the function" + val);
        }
    }
}
