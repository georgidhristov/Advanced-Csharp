using System;
using System.Linq;

namespace Problem2MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------matrix get size

            int[] sizeOfMatrix = Console.ReadLine()
                .Split(new Char[] { ' ' }, StringSplitOptions
                .RemoveEmptyEntries)
                .Select(item => int.Parse(item))
                .ToArray();

            int rows = 0,
                cols = 0;
          
            for (int i = 0; i < sizeOfMatrix.Length; i++)
            {
                rows = sizeOfMatrix[0];
                cols = sizeOfMatrix[1];
            }

            //----------------matrix get elements

            var mtr = new int[rows, cols];

            for (var i = 0; i < rows; i++)
            {
                var line = Console.ReadLine();

                var spl = line.Split(' ');

                if (spl.Length != cols) throw new FormatException();
                {
                    for (var j = 0; j < cols; j++)
                    {
                        mtr[i, j] = int.Parse(spl[j]);
                    }
                }
            }

            int[,] matrix = new int[rows, cols];

            matrix = mtr;

            //----------------make spider

            int bestSum = int.MinValue;

            int[,] finalResult = new int[3, 3];

            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {

                    int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                        matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                        matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                    if (sum > bestSum)
                    {
                        bestSum = sum;

                        int[,] biggerMatrix = {
                          {matrix[i, j], matrix[i, j + 1], matrix[i, j + 2]},
                          {matrix[i + 1, j], matrix[i + 1, j + 1], matrix[i + 1, j + 2]},
                          {matrix[i + 2, j], matrix[i + 2, j + 1], matrix[i + 2, j + 2]} 
                                     };
                        finalResult = biggerMatrix;
                    }
                }
            }

            //----------------matrix get print
            Console.WriteLine("Sum = {0}", bestSum);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", finalResult[i, j]);
                }
                Console.WriteLine();
            }

        }      
    }
}
