using System;
using System.Collections.Generic;

namespace Problem2TheSieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            HashSet<int> NoPrime = new HashSet<int>();

            for (int x = 2; x < number; x++)
            {
                for (int y = x * 2; y < number; y = y + x)
                {
                    if (!NoPrime.Contains(y))
                    {
                        NoPrime.Add(y);
                    }
                }
            }

            Console.Write("2");

            for (int z = 3; z <= number ; z++)
            {
                if (z != number)
                {
                    if (!NoPrime.Contains(z))
                    {
                        Console.Write(", " + z);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
