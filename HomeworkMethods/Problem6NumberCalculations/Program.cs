using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6NumberCalculations
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

            MinimumMaximumAverageSumAndProduct(numbers);

        }

        public static void MinimumMaximumAverageSumAndProduct(double[] num) 
        {
            double min = 0,
                   max = 0,
                   average = 0,
                   sum = 0,
                   product = 1;

            for (int i = 0; i < num.Length; i++)
            {
                min = num.Min();
                max = num.Max();
                average = num.Average();
                sum = sum + num[i];
                product = product * num[i];
            }
            Console.WriteLine("min = {0}",min);
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("average = {0}", average);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("product = {0}", product);
        }
    }
}
