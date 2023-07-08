using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindPrimeNumsInBaseK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(999999, 3));
        }
    }

    public class Solution
    {
        int answer;
        public int solution(int n, int k)
        {
            answer = 0;

            string transform = TransformNToBaseK(n, k);
            string[] numStr = transform.Split('0');
            CheckCondition(numStr.Select(s => string.IsNullOrEmpty(s) ? "1" : s).Select(long.Parse).ToArray());
            return answer;
        }

        private string TransformNToBaseK(int n, int k)
        {
            List<long> list = new List<long>();
            StringBuilder sb = new StringBuilder();
            while (n >= k)
            {
                list.Insert(0, n % k);
                n /= k;
            }
            list.Insert(0, n);
            for (int i = 0; i < list.Count; i++)
            {
                sb.Append(list[i]);
            }
            return sb.ToString();
        }

        private void CheckCondition(long[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (CheckPrimeNum(nums[i]))
                {
                    answer++;
                }
            }
        }

        private bool CheckPrimeNum(long num)
        {
            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
