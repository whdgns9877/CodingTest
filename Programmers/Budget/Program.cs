using System;
using System.Collections.Generic;

namespace Budget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] d = { 1, 3, 2, 5, 4 };
            Console.WriteLine(solution.solution(d, 9));
        }
    }

    public class Solution
    {
        public int solution(int[] d, int budget)
        {
            int answer = 0;
            int curSum = 0;
            List<int> dList = new List<int>(d);
            dList.Sort();

            for(int i = 0; i < dList.Count; i++)
            {
                if(curSum + dList[i] > budget)
                {
                    break;
                }
                curSum += dList[i];
                answer ++;
            }

            return answer;
        }
    }
}
