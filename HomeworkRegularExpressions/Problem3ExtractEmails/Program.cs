using System;
using System.Text.RegularExpressions;

namespace Problem3ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string regular = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

            Regex myRegex = new Regex(regular);

            MatchCollection matches = myRegex.Matches(input);

            foreach (Match item in matches)
            {
                Console.WriteLine(item);
            }

        }
    }
}
