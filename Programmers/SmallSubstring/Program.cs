using System;
using System.Collections.Generic;

namespace SmallSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string t = "3141592";
            string p = "271";
            solution.solution(t, p);
        }
    }

    public class Solution
    {
        public int solution(string t, string p)
        {
            int answer = 0;
            long compareNum = Convert.ToInt64(p);
            int lenght = p.Length;

            List<long> numList = new List<long>();

            for(int i = 0; i < t.Length - lenght + 1; ++i)
            {
                numList.Add(long.Parse(t.Substring(i, lenght)));
            }

            foreach(long num in numList)
            {
                if (num <= compareNum) answer++;
            }

            return answer;
        }
    }
}
