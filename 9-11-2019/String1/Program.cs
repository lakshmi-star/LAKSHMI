using System;

namespace String1
{
    class StringType
    {
        static void Main(string[] args)
        {
            String s1 = "Gud Morning";
            Char[] ch = { 't', 'o', 'm', 'y', 'f', 'a', 'm', 'i', 'l', 'y' };
            String s2 = new string(ch);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
