using System;

namespace AccessPublic
{
    class A
    {
        public string name = "Lakshmi";
        public void Msg(string msg)
        {
            Console.WriteLine("Hello" + msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
        A a = new A();
        Console.WriteLine("Hello" + a.name);
            a.Msg("Avula");
}
}
}