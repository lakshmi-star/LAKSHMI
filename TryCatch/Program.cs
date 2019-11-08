using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter ist number");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter 2nd number");
                int y = int.Parse(Console.ReadLine());
                int z = x / y;
                Console.WriteLine("the result is:" + z);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("End of the program");
        }
    }
}
