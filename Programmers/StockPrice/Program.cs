using System;
using System.Collections.Generic;

namespace StockPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] prices = { 1, 2, 3, 2, 3 };
            Console.WriteLine(solution.solution(prices));
        }
    }

    public class Solution
    {
        public int[] solution(int[] prices)
        {
            int[] answer = new int[prices.Length];

            for(int i = 0; i < prices.Length - 1; i++)
            {
                int fallTime = 0;
                for(int j = i + 1; j < prices.Length; j++)
                {
                    fallTime++;
                    if (prices[i] > prices[j])
                    {
                        break;
                    }
                }
                answer[i] = fallTime;
            }

            return answer;
        }
    }
}
