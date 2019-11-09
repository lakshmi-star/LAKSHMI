using System;

namespace String4
{
    class Program
    {
        static void Main(string[] args)
        {
            String s1 = "I am learning C#";

            Console.WriteLine(s1.Substring(5,3)); //substring(start , how many)

            Console.WriteLine(s1.Replace("C#", "Java")); //replacing C# with java

            Console.WriteLine(s1.IndexOf('n'));  //here to find out the position of n
        }
    }
}
