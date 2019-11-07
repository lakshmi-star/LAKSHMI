using System;

namespace Function1
{
    class Animal
    {
        public void show(String msg)
        {
            Console.WriteLine("Hello" + msg);
        }
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            a1.show("parrot");
        }
    }
}
