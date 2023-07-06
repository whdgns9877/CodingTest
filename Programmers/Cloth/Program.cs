using System;
using System.Collections.Generic;
using System.Linq;

namespace Cloth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[,] clothes = { { "yellow_hat", "headgear" }, { "blue_sunglasses", "eyewear" }, { "green_turban", "headgear" } };
            Console.WriteLine(solution.solution(clothes));
        }
    }

    public class Solution
    {
        public int solution(string[,] clothes)
        {
            int answer = 1;
            Dictionary<string, int> clothDic = new Dictionary<string, int>();

            for (int i = 0; i < clothes.GetLength(0); i++)
            {
                if (!clothDic.ContainsKey(clothes[i, 1]))
                {
                    clothDic.Add(clothes[i, 1], 1);
                }
                else
                {
                    clothDic[clothes[i, 1]] += 1;
                }
            }


            int[] vals = clothDic.Values.ToArray();

            for (int j = 0; j < vals.Length; j++)
            {
                answer *= vals[j] + 1;
            }

            return answer - 1;
        }
    }
}
