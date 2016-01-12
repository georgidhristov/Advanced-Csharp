using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1InsertionSort
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

            List<int> allNumbers = new List<int>();

            List<int> sortNumbers = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                allNumbers.Add(numbers[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < allNumbers.Count; j++)
                {
                    int min = allNumbers.Min();
                    allNumbers.Remove(min);
                    sortNumbers.Add(min);
                }
            }

            Console.Write(string.Join(" ", sortNumbers));

            Console.WriteLine();
        }
    }
}
