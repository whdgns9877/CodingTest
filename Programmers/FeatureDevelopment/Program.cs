using System;
using System.Collections.Generic;
using System.Linq;

namespace FeatureDevelopment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] progresses = { 93, 30, 55 };
            int[] speeds = { 1, 30, 5 };
            Console.WriteLine(solution.solution(progresses, speeds));

        }
    }

    public class Solution
    {
        public int[] solution(int[] progresses, int[] speeds)
        {
            int[] answer = new int[] { };

            int[] day = new int[progresses.Length];

            Dictionary<int, int> progressDic = new Dictionary<int, int>();

            for (int i = 0; i < progresses.Length; i++)
            {
                day[i] = (int)Math.Ceiling(((100 - progresses[i]) / (double)speeds[i]));
            }
            
            for(int i = 0; i < day.Length - 1; i++)
            {
                for(int j = i; j < day.Length; j++)
                {
                    if (day[i] > day[j])
                    {
                        day[j] = day[i];
                    }
                }
            }

            for(int i = 0; i < day.Length; i++)
            {
                if (!progressDic.ContainsKey(day[i]))
                {
                    progressDic.Add(day[i], 1);
                }
                else
                {
                    progressDic[day[i]] += 1;
                }
            }

            answer = progressDic.Values.ToArray();

            return answer;
        }
    }
}
