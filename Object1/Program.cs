using System;

namespace Object1
{
    class Student
    {
        public int id;
        public String name;
        public void insert(int i, String n)
        {
            id = i;
            name = n;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name);
        }
    }
    class TestStudent
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();
            s1.insert(101, "lakshmi");
            s2.insert(102, "lavanya");
            s1.display();
            s2.display();
        }
    }
}
