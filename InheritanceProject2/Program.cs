using System;

namespace InheritanceProject2
{
    public class bird
    {
        public void eat()
        {
            Console.WriteLine("eating");
        }
    }
    public class Parrot : bird
    {
        public void sing()
        {
            Console.WriteLine("singing");
        }
    }
    public class ChildParrot: Parrot
    {
        public void fly()
        {
            Console.WriteLine("flying");
        }
    }
    class TestInheritance2
    {

         public static void Main(string[] args)
        {
            ChildParrot c1 = new ChildParrot();
            c1.eat();
            c1.sing();
            c1.fly();
        }
    }
}
