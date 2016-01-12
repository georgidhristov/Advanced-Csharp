using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem4OlympicsAreComing
{
    class Program
    {
        static void Main(string[] args)
        {
            string SplitPattern = @"\s*\|\s*";
            Regex regex = new Regex(SplitPattern);

            var dict = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "report")
            {
                string[] tokens = regex.Split(input.Trim());
                string athlete = Regex.Replace(tokens[0].Trim(), @"\s+", " ");
                string country = Regex.Replace(tokens[1].Trim(), @"\s+", " ");

                if (!dict.ContainsKey(country))
                {
                    dict.Add(country, new List<string>());
                }

                dict[country].Add(athlete);

                input = Console.ReadLine();
            }

            var orderedCountryData = dict
                .OrderByDescending(x => x.Value.Count);

            foreach (var country in orderedCountryData)
            {
                Console.WriteLine(
                    "{0} ({1} participants): {2} wins",
                    country.Key,
                    country.Value.Distinct().Count(),
                    country.Value.Count);
            }
        }
    }
}
