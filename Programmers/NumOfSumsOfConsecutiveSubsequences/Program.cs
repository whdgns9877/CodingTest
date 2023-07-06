using System;
using System.Collections.Generic;
using System.Linq;

namespace NumOfSumsOfConsecutiveSubsequences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] elements = { 7, 9, 1, 1, 4 };
            Console.WriteLine(solution.solution(elements));
        }
    }

    public class Solution
    {
        public int solution(int[] elements)
        {
            HashSet<int> sumSet = new HashSet<int>();

            for (int i = 1; i <= elements.Length; i++)
            {
                int sum = 0;

                for (int start = 0; start < elements.Length; start++)
                {
                    int end = (start + i) % elements.Length;
                    sum += elements[end];
                    sumSet.Add(sum);
                }
            }

            return sumSet.Count;
        }
    }


}
