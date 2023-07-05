using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseMandarin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] tangerine = { 1, 3, 2, 5, 4, 5, 2, 3 };
            Console.WriteLine(solution.solution(6, tangerine));
        }
    }

    public class Solution
    {
        public int solution(int k, int[] tangerine)
        {
            int answer = 0;
            Dictionary<int, int> tanDic = new Dictionary<int, int>();

            foreach (int i in tangerine) 
            {
                if (!tanDic.ContainsKey(i))
                {
                    tanDic.Add(i, 1);
                }
                else
                {
                    tanDic[i] += 1;
                }
            }

            List<int> tangerineNums = new List<int>(tanDic.Values);
            tangerineNums.Sort();
            int curTangerine = 0;

            while(k > curTangerine)
            {
                curTangerine += tangerineNums.Last();
                tangerineNums.RemoveAt(tangerineNums.Count - 1);
                answer++;
            }

            return answer;
        }
    }
}
