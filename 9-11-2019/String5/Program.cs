using System;

namespace String5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str_array = new string[3];
            str_array[0] = "lakshmi";
            str_array[1] = "lavanya";
            str_array[2] = "Nandini";

            for(int i =0; i < 3; i++)
            {
                Console.WriteLine("value at index position of" + i + "is" + str_array[i]);
            }
           
        }
    }
}
