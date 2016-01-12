using System;
using System.Linq;

namespace Problem4LinearAndBinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console
                .ReadLine()
                .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(item => int.Parse(item))
                .ToArray();

            int num = int.Parse(Console.ReadLine());

            int result = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    if (result == -1)
                    {
                        result = i;
                    } 
                }              
            }
            Console.WriteLine(result);
        }
    }
}
