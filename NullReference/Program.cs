using System;

namespace NullReference
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = null;
                int n = numbers[0];
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("end of the program");
        }
    }
}
