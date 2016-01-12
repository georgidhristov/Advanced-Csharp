using System;
using System.Linq;

namespace Problem4SequenceInMatrix
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

            var mtr = new string[rows, cols];

            for (var i = 0; i < rows; i++)
            {
                var line = Console.ReadLine();

                var spl = line.Split(' ');

                if (spl.Length != cols) throw new FormatException();
                {
                    for (var j = 0; j < cols; j++)
                    {
                        mtr[i, j] = spl[j];
                    }
                }
            }

            string[,] matrix = new string[rows, cols];

            matrix = mtr;

            //----------------make spider

            string longestSequence = "";

            string cheker = "";

            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {                    
                    if (matrix[i, j] == matrix[i, j + 1] && matrix[i, j + 1] == matrix[i,j + 2])
                    {
                        cheker = matrix[i, j ] + ", " + matrix[i, j + 1] + ", " + matrix[i, j + 2];
                    }
                    else if (matrix[i, j] == matrix[i + 1, j] && matrix[i + 1, j] == matrix[i + 2, j])
                    {
                        cheker = matrix[i, j] + ", " + matrix[i + 1, j] + ", " + matrix[i + 2, j];
                    }
                    else if (matrix[i, j + 1] == matrix[i + 1, j + 1] && matrix[i + 1, j + 1] == matrix[i + 2, j + 1])
                    {
                        cheker = matrix[i, j + 1] + ", " + matrix[i + 1, j + 1] + ", " + matrix[i + 2, j + 1];
                    }
                    else if (matrix[i, j + 2] == matrix[i + 1, j + 2] && matrix[i + 1, j + 2] == matrix[i + 2, j + 2])
                    {
                        cheker = matrix[i, j + 2] + ", " + matrix[i + 1, j + 2] + ", " + matrix[i + 2, j + 2];
                    }
                    else if (matrix[i, j] == matrix[i + 1, j + 1] && matrix[i + 1, j + 1] == matrix[i + 2, j + 2])
                    {
                        cheker = matrix[i, j] + ", " + matrix[i + 1, j + 1] + ", " + matrix[i + 2, j + 2];
                    }

                    if (cheker.Length > longestSequence.Length)
                    {
                        longestSequence = cheker;
                    }
                }
            }
            Console.WriteLine(longestSequence);
        }
    }
}
