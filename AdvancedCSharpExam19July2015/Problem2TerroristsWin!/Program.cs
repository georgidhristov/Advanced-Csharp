using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem2TerroristsWin_
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string bomb = null;
            bomb = bomb + Regex.Match(input, @"[\|\S*\|]+").ToString();

            Console.WriteLine(bomb);

            byte[] asciiBytes = Encoding.ASCII.GetBytes(bomb);

            int bombAsciiSum = 0;
            for (int i = 0; i < asciiBytes.Length; i++)
            {
                bombAsciiSum = bombAsciiSum + asciiBytes[i];
            }

            List<int> f = new List<int>();
            if (bombAsciiSum > 9 && bombAsciiSum < 100)
            {
                f.Add(bombAsciiSum / 10);
                f.Add(bombAsciiSum % 10);
            }

            
        }
    }
}
