using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("../../read.txt"))
            {
                using (var writer = new StreamWriter("../../write.txt"))
                {
                    string line = reader.ReadLine();

                    int row = 1;

                    while (line != null)
                    {
                        writer.Write(row + ": ");   
                        for (int i = 0; i <= line.Length - 1; i++)
                        {
                            writer.Write(line[i]);
                        }
                        row++;
                        writer.WriteLine();   
                        
                        
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
