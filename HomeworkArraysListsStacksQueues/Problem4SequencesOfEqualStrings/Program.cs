using System;

namespace Problem4SequencesOfEqualStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string[] input = Console.ReadLine().Split(' ');

            for (i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    Console.Write("{0} ", input[i]);
                }
                else
                {
                    Console.WriteLine("{0}", input[i]);
                }
            }
            Console.WriteLine("{0}", input[i]);
        }
    }
}
