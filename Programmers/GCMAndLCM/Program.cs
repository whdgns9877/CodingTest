using System;
using System.Collections.Generic;

namespace GCFAndLCM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(2,5));
        }
    }

    public class Solution
    {
        public int[] solution(int n, int m)
        {
            int[] answer = new int[2];

            int low = 0;
            int high = 0;

            if (n > m)
            {
                low = m;
                high = n;
            }
            else
            {
                low = n;
                high = m;
            }

            if(m % n == 0)
            {
                answer[0] = low;
                answer[1] = high;
            }
            else
            {
                List<int> lowDivisorList = GetDivisorsList(low);
                List<int> highDivisorList = GetDivisorsList(high);
                int curGCF = 0;
                foreach(int divisor in lowDivisorList)
                {
                    if (highDivisorList.Contains(divisor) && divisor > curGCF) curGCF = divisor;
                }
                answer[0] = curGCF;
                answer[1] = (low * high) / curGCF;
            }

            return answer;
        }

        private List<int> GetDivisorsList(int num)
        {
            List<int> list = new List<int>();

            for(int i = 1; i <= num; i++)
            {
                if(num % i == 0) list.Add(i);
            }

            return list;

        }
    }
}
