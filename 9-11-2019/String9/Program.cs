using System;

namespace String9
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "Lakshmi12royal34";
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                { 
                    Console.WriteLine("{0} is a number");
                }
                else
                {
                    Console.WriteLine("{0} is a character");

                }
            }
            }
           
        }
    }

