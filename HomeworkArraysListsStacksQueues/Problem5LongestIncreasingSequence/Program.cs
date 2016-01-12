using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5LongestIncreasingSequence
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
            
            int longStart = 0,
                start = 0,
                longEnd = 0,
                longLength = 0,
                length = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {

                Console.Write(numbers[i]);

                if (numbers[i] < numbers[i + 1])
                {
                    Console.Write(" ");
                    length++;
                }
                else
                {
                    Console.WriteLine();  //----------- Console.ReadLine();

                    if (length > longLength)
                    {
                        longLength = length;
                        longStart = start;
                        longEnd = i;
                    }

                    length = 0;
                    start = i + 1;

                }
            }

            Console.WriteLine(numbers[numbers.Length - 1]);

            if (length > longLength)
            {
                longLength = length;
                longStart = start;
                longEnd = numbers.Length - 1;
            }

            Console.Write("Longest:");

            for (int i = longStart; i <= longEnd; i++)
            {
                Console.Write(" {0}", numbers[i]);
            }

            Console.WriteLine();

        }
    }
}
