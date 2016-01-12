using System;

namespace Problem4FirstLargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
            int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
            int[] sequenceThree = { 1, 1, 1 };

            Console.WriteLine(GetIndexOfFirstElementLargerThenNeighbours(sequenceOne));
            Console.WriteLine(GetIndexOfFirstElementLargerThenNeighbours(sequenceTwo));
            Console.WriteLine(GetIndexOfFirstElementLargerThenNeighbours(sequenceThree));

        }

        public static int GetIndexOfFirstElementLargerThenNeighbours(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                if (arr[i + 1] > arr[i] && arr[i + 1] > arr[i + 2])
                {
                    count++;
                    int index = Array.IndexOf(arr, arr[i + 1]);
                    return index;
                }
            }
            if (count == 0)
            {
                return -1;
            }
            return arr.Length;
        }
    }
}
