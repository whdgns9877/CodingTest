using System;
using System.Collections.Generic;
using System.Linq;

namespace HallOfFrame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] score = { 0, 300, 40, 300, 20, 70, 150, 50, 500, 1000 };
            int[] answer = solution.solution(4, score);
            foreach (var item in answer)
            {
                Console.Write(item + " "); 
            }
        }
    }

    public class Solution
    {
        public int[] solution(int k, int[] score)
        {
            List<int> list = new List<int>();
            int[] answer = new int[score.Length];
            int idx = 0;

            foreach (int num in score)
            {
                if (idx < k)
                {
                    list.Add(num);
                }
                else if (list.Min() < num)
                {
                    list.Remove(list.Min());
                    list.Add(num);
                }
                answer[idx] = list.Min();
                idx++;
            }

            return answer;
        }
    }
}
