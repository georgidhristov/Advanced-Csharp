using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem3MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "start";

            int rows = 0,
                cols = 0;

            List<string> inputNumbers = new List<string>();
            List<string> swap = new List<string>();
            
            int spin = 0;
            while (str != "END")
            {
                spin++;
                str = Console.ReadLine();

                if (spin == 1)
                {
                    rows = int.Parse(str);
                }
                else if (spin == 2)
                {
                    cols = int.Parse(str);
                }

                if (str != "END")
                {
                    if (str.Contains("swap"))
                    {
                        swap.Add(str);
                    }
                    else if (spin > 2)
                    {
                        inputNumbers.Add(str);
                    }
                }
            }

            string[,] matrix = new string[rows, cols];

            int step = 0;
            for (int i = 0; i < rows; i++)
            {        
                for (int j = 0; j < cols; j++)
                {
                    step++;
                    if (step <= cols)
                    {
                        matrix[i, j] = inputNumbers[j];
                    }
                    else if (step <= cols*2)
                    {
                        matrix[i, j] = inputNumbers[j + 3];
                    }
                    else if (step <= cols * 3)
                    {
                        matrix[i, j] = inputNumbers[j + 6];
                    }
                }
            }

            string swapNumbers = "";

            for (int i = 0; i < swap.Count; i++)
            {
                swapNumbers = Regex.Replace(swap[i], @"[^0-9]+", "");
            }

            string[,] finalResult = new string[rows, cols];

            int one = Convert.ToInt32(swapNumbers.ToString().Substring(0, 1));
            int two = Convert.ToInt32(swapNumbers.ToString().Substring(1, 1));
            int three = Convert.ToInt32(swapNumbers.ToString().Substring(2, 1));
            int four = Convert.ToInt32(swapNumbers.ToString().Substring(3, 1));

            string magicString = "";

            for (int rounds = 0; rounds < swap.Count; rounds++)
            {
                magicString = matrix[one, two];
                matrix[one, two] = matrix[three, four];
                matrix[three, four] = magicString;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(finalResult[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
