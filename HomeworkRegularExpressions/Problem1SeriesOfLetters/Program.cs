using System;

namespace Problem1SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string output = "";

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input[i+1])
                {
                    output = output + input[i];
                }
                else if (i == input.Length)
                {
                    output = output + input[i];
                }
            }

            Console.WriteLine(output);
        }
    }
}
