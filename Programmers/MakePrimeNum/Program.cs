using System;
using System.Collections.Generic;

namespace MakePrimeNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = { 1, 2, 7, 6, 4 };
            Console.WriteLine(solution.solution(nums));
        }
    }

    class Solution
    {
        public int solution(int[] nums)
        {
            int answer = 0;

            List<int> trippleSumList = new List<int>();

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        trippleSumList.Add(nums[k] + nums[j] + nums[i]);
                    }
                }
            }

            foreach (int num in trippleSumList)
            {
                if (IsPrimeNum(num))
                {
                    answer++;
                }
            }

            return answer;
        }

        private bool IsPrimeNum(int num)
        {
            int count = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }

            return count == 2 ? true : false;
        }
    }
}
