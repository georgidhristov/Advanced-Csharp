using System;

namespace Problem3LargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            IsLargerThenNeighbours();
        }

        public static void IsLargerThenNeighbours()
        {
            int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };

            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i + 1] > numbers[i] && numbers[i + 1] > numbers[i + 2])
                {
                    Console.WriteLine(true);
                }
                else if (i == numbers.Length - 3)
                {
                    if (numbers[i + 2] > numbers[i + 1])
                    {
                        Console.WriteLine(true);
                    }
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }
    }
}
