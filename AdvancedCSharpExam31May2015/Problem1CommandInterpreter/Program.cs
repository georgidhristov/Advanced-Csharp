using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem1CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console
                .ReadLine()
                .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int from = 0;
            int count = 0;
            string commands = null;

            int j = 0;

            try
            {
                while (commands != "end")
                {
                    commands = Console.ReadLine();
                    if (commands != "end")
                    {
                        j++;
                        char[] digits = (commands.Where(Char.IsDigit).ToArray());

                        if (commands.Contains("reverse"))
                        {
                            from = digits[0] - 48;
                            count = digits[1] - 48;

                            numbers = ReverseMethod(numbers, from, count);
                        }

                        if (commands.Contains("sort"))
                        {
                            from = digits[0] - 48;
                            count = digits[1] - 48;

                            numbers = SortMethod(numbers, from, count);
                        }

                        if (commands.Contains("rollLeft"))
                        {
                            count = digits[0] - 48;

                            numbers = rollLeftMethod(numbers, count);
                        }

                        if (commands.Contains("rollRight"))
                        {
                            count = digits[0] - 48;

                            numbers = rollRightMethod(numbers, count);
                        }
                    }
                }
            }
            catch (Exception)
            {
                for (int i = 0; i < j; i++)
                {
                    Console.WriteLine("Invalid input parameters.");
                }
            }
                Console.Write("[");
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i < numbers.Length - 1)
                    {
                        Console.Write(numbers[i] + ", ");
                    }
                    else
                    {
                        Console.Write(numbers[i]);
                    }
                }
                Console.WriteLine("]");
        }

        public static string[] ReverseMethod(string[] arr, int one, int two)
        {
            string str = null;

            for (int i = two + 1; i > one - 1; i--)
            {
                str = str + arr[i];
            }

            for (int i = 0; i < two; i++)
            {
                arr[i + one] = str[i].ToString();
            }
            return arr;
        }

        public static string[] SortMethod(string[] arr, int one, int two)
        {
            List<int> allNumbers = new List<int>();

            List<int> sortNumbers = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int magic = 0;
                magic = int.Parse(arr[i]);
                magic = Convert.ToInt32(arr[i]);
          
                allNumbers.Add(magic);
            }           

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < allNumbers.Count; j++)
                {
                    int min = allNumbers.Min();
                    allNumbers.Remove(min);
                    sortNumbers.Add(min);
                }
            }

            string[] result = new string[sortNumbers.Count];
            for (int i = 0; i < sortNumbers.Count; i++)
            {
                result[i] = sortNumbers[i].ToString() ;
            }
           

            return arr;
        }
        public static string Alphabetize(string s)
        {
            char[] a = s.ToCharArray();
            Array.Sort(a);
            return new string(a);
        }

        static string[] rollLeftMethod(string[] array, int count)
        {
            return array.Skip(count).Concat(array.Take(count)).ToArray();
        }

        static string[] rollRightMethod(string[] array, int count)
        {
            return array.Skip(array.Length - count).Concat(array.Take(array.Length - count)).ToArray();
        }

    }
}
