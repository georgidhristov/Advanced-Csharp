﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem6SubsetSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 

            int[] numbers = Console
                .ReadLine()
                .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(item => int.Parse(item))
                .ToArray();

            Array.Sort(numbers);

            List<int> sumIsN = new List<int>();
            List<List<int>> sumOfAll = new List<List<int>>();

            int sum = 0;
            double combined = Math.Pow(2, numbers.Length);
            for (int i = 0; i < combined; i++)
            {
                sum = 0;

                for (int j = 0; j < numbers.Length; j++)
                {
                    int mask = i & (1 << j);
                    if (mask != 0)
                    {
                        sum = sum + numbers[numbers.Length - 1 - j];
                        sumIsN.Add(numbers[numbers.Length - 1 - j]);
                    }
                }

                if (sum == n)
                {
                    sumOfAll.Add(sumIsN);
                }
                sumIsN = new List<int>();
            }

            if (sumOfAll.Count == 0)
            {
                Console.WriteLine("No matching subsets.");
            }
            else
            {
                List<List<int>> sortedList = new List<List<int>>(sumOfAll.OrderBy(x => x.Count));
                foreach (var item in sortedList)
                {
                    item.Sort();
                }

                for (int i = 0; i < sortedList.Count - 1; i++)
                {
                    int first = sortedList[i].First();

                    for (int j = 0; j < sortedList.Count; j++)
                    {
                        int second = sortedList[j].First();

                        if (sortedList[i].Count == sortedList[j].Count && first > second)
                        {
                            List<int> temp = sortedList[i];
                            sortedList[i] = sortedList[j];
                            sortedList[j] = temp;
                        }
                    }
                }
                foreach (var item in sortedList)
                {
                    Print(item,n);
                }
            }
        }
        static void Print(List<int> nums, int sum)
        {

            foreach (var item in nums)
            {
                Console.Write(item + " + ");
            }
            Console.WriteLine("\b\b\b = " + sum);
        }
    }
}
