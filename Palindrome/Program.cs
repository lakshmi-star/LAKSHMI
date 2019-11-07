using System;

namespace Palindrome
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n, r, sum = 0, temp;
            Console.WriteLine("enter the number");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum * 10 + r;
                n = n / 10;
            }
            if (temp == sum)

                Console.Write("number is palindrome");

            else

                Console.Write("number is not palindrome");
        }
        
    }
}
