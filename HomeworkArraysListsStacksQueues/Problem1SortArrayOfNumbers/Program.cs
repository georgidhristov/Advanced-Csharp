using System;
using System.Linq;

namespace Problem1SortArrayOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console
                .ReadLine()
                .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(item => int.Parse(item))
                .ToArray();

            Array.Sort(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
