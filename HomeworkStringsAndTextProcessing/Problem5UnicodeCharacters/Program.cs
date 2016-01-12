using System;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem5UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(ConvertToUnicode(input));
        }

        static string ConvertToUnicode(string str)
        {
            StringBuilder utf = new StringBuilder(str.Length * 6);

            foreach (char c in str)
                utf.AppendFormat("\\u{0:X4}", (int)c);

            return utf.ToString();
        }
    }
}
