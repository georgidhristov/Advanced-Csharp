using System;
using System.Linq;

namespace Problem1ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            input = new string(input.Reverse().ToArray()); 

            Console.WriteLine(input);
        }
    }
}
