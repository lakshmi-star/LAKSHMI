using System;

namespace String7
{
    class Program
    {
        static void Main(string[] args)
        {
            String sentence = "Hi to all";
            int start_pos = sentence.IndexOf(" ") + 1; // take first space position value
            int end_pos = sentence.IndexOf(" ", start_pos) - start_pos; //take second space position value
            String word = sentence.Substring(start_pos, end_pos); //extract the second word from position
            Console.WriteLine(word);
        }
    }
}
