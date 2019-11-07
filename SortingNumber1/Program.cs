using System;


    class Program
    {
    static void Main(string[] args)
    {
        int[] array = new int[] { 3, 5, 10, 8, 7, 6, 2 };
        int temp;
        int i = 0;
        while (i < array.Length)
        {
            int j = i + 1;
            while (j < array.Length)
            {
                if (array[i] > array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
                j++;
            }
            i++;
        }
        foreach (int value in array)
        {
            Console.Write(value + " ");
        }
    }

    }

