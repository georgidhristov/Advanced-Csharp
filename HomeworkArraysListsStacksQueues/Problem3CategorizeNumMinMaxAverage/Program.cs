using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3CategorizeNumMinMaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console
                    .ReadLine()
                    .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(item => double.Parse(item))
                    .ToArray();

            List<double> myInt = new List<double>();
            List<double> myDouble = new List<double>();
            for (int i = 0; i < numbers.Length; i++)
            {
                double cheker = numbers[i];
                bool isInteger = unchecked(cheker == (int)cheker);

                if (isInteger == true)
                {
                    myInt.Add(cheker);
                }
                else if (isInteger == false)
                {
                    myDouble.Add(cheker);
                }
            }

            double min = 0,
                   max = 0,
                   sum = 0,
                   avg = 0;

            for (int i = 0; i < myDouble.Count; i++)
            {
                min = myDouble.Min();
                max = myDouble.Max();
                sum = sum + myDouble[i];
                avg = myDouble.Average();
            }
            Console.Write("[");
            Console.Write(string.Join(", ", myDouble));
            Console.WriteLine("] -> min: {0}, max: {1}, sum: {2}, avg: {3:f2}", min, max, sum, avg);
            Console.WriteLine();

            min = 0;
            max = 0;
            sum = 0;
            avg = 0;

            for (int i = 0; i < myInt.Count; i++)
            {
                min = myInt.Min();
                max = myInt.Max();
                sum = sum + myInt[i];
                avg = myInt.Average();
            }
            Console.Write("[");
            Console.Write(string.Join(", ", myInt));
            Console.WriteLine("] -> min: {0}, max: {1}, sum: {2}, avg: {3:f2}", min, max, sum, avg);
        }
    }
}
