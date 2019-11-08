using System;

namespace params1
{
    class Program
{
    public void show(params int[] val)
    {
        for(int i = 0; i < val.Length; i++)
        {
            Console.WriteLine(val[i]);
        }
    }
    static void Main(string[] args)
    {
        Program program = new Program();

        program.show(2, 4, 6, 8, 5, 3);
    }
}
}
