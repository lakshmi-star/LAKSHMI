using System;

namespace Interface
{
    public interface drawable
    {
        void draw();
    }
    public class Rectangle : drawable
    {
        public void draw()
        {
            Console.WriteLine("drawing rectangle");
        }
    }
    public class Circle : drawable
    {
        public void draw()
        {
            Console.WriteLine("drawing circle");
        }
    }
    class TestInheritance4
    {
     public static void Main(string[] args)
        {

            drawable d;
            d = new Rectangle();
            d.draw();
            d = new Circle();
            d.draw();
        }
    }
}
