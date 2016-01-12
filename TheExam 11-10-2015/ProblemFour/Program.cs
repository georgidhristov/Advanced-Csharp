using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProblemFour
{
    class Program
    {
        static void Main(string[] args)
        {
            const string SplitPattern = @"\@[A-z\s]+";
            Regex regex = new Regex(SplitPattern);

            var countryData = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            List<int> sum = new List<int>();
            while (input != "End")
            {
                string[] tokens = regex.Split(input.Trim());

                string people = Regex.Replace(tokens[0].Trim(), @"\s+", "");
                string price = Regex.Replace(tokens[1].Trim(), @"\s+", " ");

                if (!countryData.ContainsKey(price))
                {
                    countryData.Add(price, new List<string>());
                }
                countryData[price].Add(people);

                input = Console.ReadLine();
            }


        }
    }
}
