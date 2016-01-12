using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem3WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var readWords = new StreamReader("../../words.txt"))
            {
                using (var readText = new StreamReader("../../text.txt"))
                {
                    using (var writeResult = new StreamWriter("../../result.txt"))
                    {
                        string line = "";
                        List<string> searchWords = new List<string>();
                        while (line != null)
                        {
                            line = readWords.ReadLine();
                            searchWords.Add(line);   
                        }
                        
                        string row = "";

                        string str = "";
                        while (row != null)
                        {
                            row = readText.ReadLine();
                            str = str + row + " ";
                        }

                        str = str.ToLower();
                        

                        string[] splitArr = str.Split().ToArray();

                        int count = 0;
                        for (int i = 0; i < searchWords.Count - 1; i++)
                        {
                            for (int j = 0; j < splitArr.Length; j++)
                            {
                                if (i == 0)
                                {
                                    if (searchWords[0] == splitArr[])
                                    {
                                        Console.WriteLine(searchWords[0]);
                                        count++;
                                        Console.WriteLine(count);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
