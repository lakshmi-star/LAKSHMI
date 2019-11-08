using System;

namespace InvalidCaste
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Object obj = new object();  //super class
                String str = (string)obj;   //super class cannot downcasting to sub class
                Console.WriteLine("from try block");
            }
            catch(InvalidCastException ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine("final statement in this program");
        }
    }
}
