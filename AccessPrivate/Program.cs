using System;

namespace AccessPrivate
{
    class D
    {
        private string name = "lakshmi";
        private void Msg(string msg)
        {
            Console.WriteLine("Hello" + msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            D d = new D();

            Console.WriteLine("Hello" + d.name);
            d.Msg("lakky");
        }
    }
}
