using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _01PrimeFactorization
{
    class Program
    {
        static void Main(string[] args)
        {
            long subject = long.Parse(Console.ReadLine());
            List<long> factors = new List<long>();

            while (subject > 1)
            {
                var nextFactor = 2;

                if (subject % nextFactor > 0)
                {
                    nextFactor = 3;
                    do
                    {
                        if (subject % nextFactor == 0)
                        {
                            break;
                        }

                        nextFactor += 2;

                    } while (nextFactor < subject);
                }

                subject /= nextFactor;
                factors.Add(nextFactor);         
            }

            var factorAnswer = 1L;

            factors.ForEach(f => factorAnswer = factorAnswer * f);

            Console.WriteLine("{1} = {0}"
                    ,string.Join(" * ",factors
                    .Select(i => i.ToString())
                    .ToArray())
                    ,factorAnswer);
        }
    }
}
