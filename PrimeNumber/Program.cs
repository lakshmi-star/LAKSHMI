using System;

namespace PrimeNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n, i, m = 0, flag = 0;

            Console.WriteLine("Enter the numbers to check prime");
            n = int.Parse(Console.ReadLine());
            n = m / 2;
            for(i = 2; i <= m;i++)
            {
                if(n % i == 0)
                {
                    Console.WriteLine("number is not prime");
                    flag = 1;
                    break;
                }
                else
                {
                    Console.WriteLine("number is prime");
                    flag = 0;
                }
            }
        }
    }
}
