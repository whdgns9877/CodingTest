using System;
using System.Collections.Generic;

namespace DivisibleArrayOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] arr = { 5, 9, 7, 10 };
            Console.WriteLine(solution.solution(arr, 5));
        }
    }

    public class Solution
    {
        public int[] solution(int[] arr, int divisor)
        {
            List<int> arrList = new List<int>();
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % divisor == 0) arrList.Add(arr[i]);
            }
            if (arrList.Count == 0)
            {
                arrList.Add(-1);
            }
            return arrList.ToArray();
        }
    }
}
