using System;

namespace MismatchException
{
    class A1
    {
        static void Main(string[] args)
        {
            try
            {
                String[] array1 = { "ant", "box", "ball", "cat" };
                Object[] array2 = array1;

                Console.WriteLine(array2[0] = "chair");
                Console.WriteLine(array2[0] = 34);
                Console.WriteLine("from try block");
            }
            catch(ArrayTypeMismatchException ex)
            {
                Console.WriteLine("catch will handle the exception" + ex);
            }
            Console.WriteLine("end of the program");
        }
    }
}
