using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProblemThree
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string strDouble = null;
            string strInt = null;

            while (input != "//END_OF_CODE")
            {


                input = Regex.Replace(input, @"double\W+", "9");
                input = Regex.Replace(input, @"int\W+", "8");
                strDouble = strDouble + Regex.Match(input, @"9[A-z\d]+").ToString();
                strInt = strInt + Regex.Match(input, @"8[A-z\d]+").ToString();


                input = Console.ReadLine();
            }

            List<string> ListOfdoubles = new List<string>();
            List<string> ListOfInts = new List<string>();
            for (int i = 0; i < strDouble.Length; i++)
            {
                ListOfdoubles = strDouble.Split('9').ToList();
            }

            for (int i = 0; i < strInt.Length; i++)
            {
                ListOfInts = strInt.Split('8').ToList();
            }

            if (ListOfdoubles.Count == 0)
            {
                Console.WriteLine("Doubles: None");
            }
            else
            {
                ListOfdoubles = ListOfdoubles.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                ListOfdoubles.Sort();
                Console.Write("Doubles: ");
                Console.WriteLine(string.Join(", ", ListOfdoubles));
            }

            if (ListOfInts.Count == 0)
            {
                Console.WriteLine("Ints: None");
            }
            else
            {
                ListOfInts = ListOfInts.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                ListOfInts.Sort();
                Console.Write("Ints: ");
                Console.WriteLine(string.Join(", ", ListOfInts));
            }
        }
    }
}
