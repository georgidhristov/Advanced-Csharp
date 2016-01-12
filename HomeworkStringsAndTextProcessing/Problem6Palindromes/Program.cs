using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem6Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            MatchCollection words = Regex.Matches(input, @"\b\w+\b");
 
            var matches = words.Cast<Match>().Select(m => m.Value).OrderBy(m => m);
 
            foreach (var word in matches)
            {
                if (Palindrome(word)) Console.WriteLine(word);
                {
                    Console.WriteLine();
                }
            }
        }

        static bool Palindrome(string word)
        {
            return Enumerable.SequenceEqual(word.ToCharArray(), word.ToCharArray().Reverse());
        }
    }
}