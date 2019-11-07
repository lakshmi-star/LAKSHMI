using System;
class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[] { 2, 9, 11, 34, 56, 87 };
        int temp = 0;
        for (int i = 0; i < array.Length-1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                }
            }
            Console.WriteLine(array[i]);
        }
        Console.ReadLine();
    }
}