using System;
using System.Linq;

namespace Problem2SortArrayUsingSelectionSort
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

            int max = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        max = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = max;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
