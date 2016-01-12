using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTargetPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfMatrix = Console.ReadLine()
                .Split(new Char[] { ' ' }, StringSplitOptions
                .RemoveEmptyEntries)
                .Select(item => int.Parse(item))
                .ToArray();

            int rows = 0,
                cols = 0;

            rows = sizeOfMatrix[0];
            cols = sizeOfMatrix[1];

            string input = Console.ReadLine();

            input.ToCharArray();
            //----------------matrix get elements
            string[,] matrix = new string[rows, cols];

            
    }
}
