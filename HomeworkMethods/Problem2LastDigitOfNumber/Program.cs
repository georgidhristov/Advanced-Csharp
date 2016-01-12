using System;

namespace Problem2LastDigitOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            Console.WriteLine(GetLastDigitAsWord(numbers));
        }

        public static string GetLastDigitAsWord(int num = 0, string result = "empty") 
        {
            
            string zero = "zero",
                   one = "one",
                   two = "two",
                   three = "three",
                   four = "four",
                   five = "five",
                   six = "six",
                   seven = "seven",
                   eight = "eight",
                   nine = "nine";

            if (num % 10 == 0)
            {
                result = zero;
                return result;
            }
            else if (num % 10 == 1) 
            {
                result = one;
                return result;
            }
            else if (num % 10 % 10 == 2)
            {
                result = two;
                return result;
            }
            else if (num % 10 == 3)
            {
                result = three;
                return result;
            }
            else if (num % 10 == 4)
            {
                result = four;
                return result;
            }
            else if (num % 10 == 5)
            {
                result = five;
                return result;
            }
            else if (num % 10 == 6)
            {
                result = six;
                return result;
            }
            else if (num % 10 == 7)
            {
                result = seven;
                return result;
            }
            else if (num % 10 == 8)
            {
                result = eight;
                return result;
            }
            else if (num % 10 == 9)
            {
                result = nine;
                return result;
            }
            else
            {
                return result;
            }
        }
    }
}
