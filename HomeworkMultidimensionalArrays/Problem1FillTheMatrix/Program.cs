using System;

namespace Problem1FillTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------Pattern-A-----------------------\\

            int n = int.Parse(Console.ReadLine());

            int[,] matrixA = new int[n, n];

            //----------------regular-pattern--------------\\

            int j = 0;
            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    int k = (n * n) + 1;
                    j++;

                    if (j < k)
                    {
                        matrixA[cols, rows] = j;
                    }
                }
            }

            //----------------print-matrix--------------\\

            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    Console.Write("{0} ", matrixA[rows, cols]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //-----------------Pattern-B-----------------------\\
            
            int[,] matrixB = new int[n, n];

            //----------------regular-pattern-------------------\\

            int rowsLength = matrixB.GetLength(0);
            int colsLength = matrixB.GetLength(1);

            int row = 0,
                col = 0;

            string str = "down";

            for (int i = 1; i < (n * n) + 1; i++)
            {
                if (str == "down" && row > n - 1)
                {
                    str = "up";
                    row--;
                    col++;
                }
                else if (str == "up" && row < 0)
                {
                    str = "down";
                    row++;
                    col++;
                }

                matrixB[row, col] = i;

                if (str == "down")
                {
                    row++;
                }
                else if (str == "up")
                {
                    row--;
                }
            }

            //----------------print-matrix--------------\\

            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    Console.Write("{0} ", matrixB[rows, cols]);
                }
                Console.WriteLine();
            }
        }  
    }
}
