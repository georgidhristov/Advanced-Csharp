using System;
using System.Linq;

namespace Problem4TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console
                   .ReadLine()
                   .Split(new Char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                   .ToArray();

            string text = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                string result = new string('*', input[i].Length);

                text = text.Replace(input[i], result);
            }
            Console.WriteLine(text);
        }
    }
}
