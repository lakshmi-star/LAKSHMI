using System;

namespace InheritanceProject3
{
    class Shape
    {
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }
    class Rectangle : Shape
    {
        public int getArea()
        {
            return (width * height);
        }
    }
    class TestInheritance3
    { 
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();
            Rect.setWidth(8);
            Rect.setHeight(15);
            Console.WriteLine("Total area {0}" , Rect.getArea());
            Console.ReadKey();
        }
    }
}
