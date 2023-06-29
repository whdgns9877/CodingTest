using System;
using System.Collections.Generic;

namespace PickTwoAndAdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] numbers = { 2, 1, 3, 4, 1 };
            Console.WriteLine(solution.solution(numbers));
        }
    }

    public class Solution
    {
        public int[] solution(int[] numbers)
        {
            List<int> sumList = new List<int>();

            for(int i = 0; i < numbers.Length - 1; i++)
            {
                for(int j = i + 1; j < numbers.Length - 1; j++)
                {
                    if (!sumList.Contains(numbers[i] + numbers[j]))
                    {
                        sumList.Add(numbers[i] + numbers[j]);
                    }
                }
            }

            sumList.Sort();

            return sumList.ToArray();
        }
    }
}
