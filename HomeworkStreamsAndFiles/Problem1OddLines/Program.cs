using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("../../TextFile.txt")) 
            {
                int rowNumbers = 0;                                
                string row = reader.ReadLine();

                var list = new List<string>();

                while (row != null)
                {
                    rowNumbers++;
                    list.Add(row);
                    row = reader.ReadLine();
                }

                for (int i = 0; i < list.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("{0}", list[i]);
                    }
                }
            }    
        }
    }
}
