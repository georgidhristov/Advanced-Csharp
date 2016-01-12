using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem4SentenceExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string text = Console.ReadLine();

            Regex line = new Regex(@"(\S.+?[.!?])(?=\s+|$)");

            MatchCollection matches = line.Matches(text);

            var list = matches.Cast<Match>().Select(x => x.Value).ToList();

            list.RemoveAll(a => !a.Contains(word));

            list.ForEach(b => Console.WriteLine(b));
        }
    }
}
