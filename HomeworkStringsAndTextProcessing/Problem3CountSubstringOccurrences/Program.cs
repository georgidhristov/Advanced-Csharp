using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem3CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();

            string search = Console.ReadLine().ToLower();

            int step = 0;

            int result = 0;

            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] == search[0])
                {
                    step++;
                    for (int j = 0; j < search.Length; j++)
                    {
                        if (text[i + j] != search[j])
                        {
                            step = 0;
                        }
                    }
                    if (step != 0)
                    {
                        result++;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
