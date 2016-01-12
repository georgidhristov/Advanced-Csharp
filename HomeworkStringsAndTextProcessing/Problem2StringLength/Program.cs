using System;

namespace Problem2StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            char[] arr = new char[20];

            for (int i = 0; i < arr.Length; i++)
            {
                if (str.Length < arr.Length)
                {
                    str = str + "*";
                }
                arr[i] = str[i];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }
    }
}
