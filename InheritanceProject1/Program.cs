using System;


    public class bird
    {
        public void eat()
        {
            Console.WriteLine("eating");
        }
    }
    public class Parrot: bird
    {
        public void sing()
        {
            Console.WriteLine("singing");
        }
    }
    class TestInheritance1
    {

    public  static void Main(string[] args)
        {
            Parrot p = new Parrot();
            p.eat();
            p.sing();
        }
    }

