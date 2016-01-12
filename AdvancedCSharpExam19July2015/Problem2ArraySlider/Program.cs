using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2ArraySlider
{
    class Program
    {
        static void Main(string[] args)
        {
            string bitwiseAnd = "&",
                   bitwiseOr = "|",
                   bitwiseXor = "^",
                   subtract = "+",
                   multiply = "*",
                   divide = "/";

            int[] numbers = Console
               .ReadLine()
               .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(item => int.Parse(item))
               .ToArray();

            int[] result = numbers;

            List<string> commandsList = new List<string>();

            string commands = null;
            while (commands != "stop")
            {
                commands = Console.ReadLine();
                commandsList.Add(commands);
            }


        }
    }
}
