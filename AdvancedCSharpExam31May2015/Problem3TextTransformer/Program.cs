using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem3TextTransformer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            string str = null;
            while (input != "burp")
            {
                input = Console.ReadLine();
                if (input != "burp")
                {
                    str = str + input;
                }
            }
            if (str.Contains('$'))
            {
                dollarSign(str);
            }
            if (str.Contains('%'))
            {
                percentageSign(str);
            }
            if (str.Contains('&'))
            {
                ampersandSign(str);
            }
            if (str.Contains('’'))
            {
                quoteSign(str);
            }
        }

        public static void dollarSign(string str) 
        {
            str = Regex.Replace(str, @"\s+", " ");
            str = Regex.Match(str, @"\$\S+\$").ToString();
            str = Regex.Replace(str, @"\$", "");

            int myInt;
            char myChar;
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 != 0)
                {
                    myInt = (int)(str[i] - 1);
                    myChar = (char)myInt;
                    Console.Write(myChar);
                }
                else
                {
                    myInt = (int)(str[i] + 1);
                    myChar = (char)myInt;
                    Console.Write(myChar);
                }
            }
            Console.Write(" ");
        }

        public static void percentageSign(string str)
        {
            str = Regex.Replace(str, @"\s+", " ");
            str = Regex.Match(str, @"\%\S+\%").ToString();
            str = Regex.Replace(str, @"\%", "");

            int myInt;
            char myChar;
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 != 0)
                {
                    myInt = (int)(str[i] - 2);
                    myChar = (char)myInt;
                    Console.Write(myChar);
                }
                else
                {
                    myInt = (int)(str[i] + 2);
                    myChar = (char)myInt;
                    Console.Write(myChar);
                }
            }
            Console.Write(" ");
        }

        public static void ampersandSign(string str)
        {
            str = Regex.Replace(str, @"\s+", " ");
            str = Regex.Match(str, @"\&\S+\&").ToString();
            str = Regex.Replace(str, @"\&", "");

            int myInt;
            char myChar;
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 != 0)
                {
                    myInt = (int)(str[i] - 3);
                    myChar = (char)myInt;
                    Console.Write(myChar);
                }
                else
                {
                    myInt = (int)(str[i] + 3);
                    myChar = (char)myInt;
                    Console.Write(myChar);
                }
            }
            Console.Write(" ");
        }

        public static void quoteSign(string str)
        {
            str = Regex.Replace(str, @"\s+", " ");
            str = Regex.Match(str, @"\’\S+\’").ToString();
            str = Regex.Replace(str, @"\’", "");

            int myInt;
            char myChar;
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 != 0)
                {
                    myInt = (int)(str[i] - 4);
                    myChar = (char)myInt;
                    Console.Write(myChar);
                }
                else
                {
                    myInt = (int)(str[i] + 4);
                    myChar = (char)myInt;
                    Console.Write(myChar);
                }
            }
            Console.Write(" ");
        }
    }
}
