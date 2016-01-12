using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem3RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();

            string[] arr = Regex.Split(input, @"[\d]+").Where(x => !string.IsNullOrEmpty(x)).ToArray();
            string[] digit = Regex.Split(input, @"[^\d]+").Where(x => !string.IsNullOrEmpty(x)).ToArray();

            StringBuilder sb = new StringBuilder();

            string builder = null;
            int count = 0;
            int c = 0;
            for (int i = 0; i < digit.Length; i++)
            {
                c = int.Parse(digit[i]);
                count = arr[i].Distinct().Count();
                for (int j = 0; j < c; j++)
                {
                    
                    builder = sb.Append(arr[i]).ToString();
                }
            }
            Console.WriteLine("Unique symbols used: {0}", count);
            Console.WriteLine(builder);
        }
    }
}

        

