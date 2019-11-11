using System;
using System.Collections.Generic;

namespace List1
{
    public class Program
    {
      public static void Main(string[] args)
        {
            var names = new List<string>();     //create a list of string
            names.Add("lakshmi");
            names.Add("nagaraju");
            names.Add("savithri");
            names.Add("lavanya");
            names.Add("nandini");

            foreach (var name in names)
            {

                Console.WriteLine(name);
            }
        }
    }
}
