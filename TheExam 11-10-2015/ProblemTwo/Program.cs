using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console
                .ReadLine()
                .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(item => int.Parse(item))
                .ToArray();
          
            int row = numbers[0];
            int col =  numbers[1];

            var mtr = new string[row, col];
            for (var i = 0; i < row; i++)
            {
                var line = Console.ReadLine();
                for (var j = 0; j < col; j++)
                {
                    mtr[i, j] = line[j].ToString();
                }

            }
            string[,] matrix = new string[row, col];
            matrix = mtr;

            string directions = Console.ReadLine();



            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
