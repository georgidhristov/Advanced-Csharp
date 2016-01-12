using System;

namespace Problem1BiggerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int max = GetMax(firstNumber, secondNumber);

            Console.WriteLine(max);
        }

        public static int GetMax(int x, int y)
        {
            return Math.Max(x, y);
        }
    }
}
