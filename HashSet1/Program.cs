using System;
using System.Collections.Generic;
namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new HashSet<string>();
            names.Add("lakky");
            names.Add("lucky");
            names.Add("lakshmi");
            names.Add("bujji");
            names.Add("lucky");         //it will not be added because it is duplicate value.

            foreach (var name in names)
            {

                Console.WriteLine(name);
            }
        }
    }
}
