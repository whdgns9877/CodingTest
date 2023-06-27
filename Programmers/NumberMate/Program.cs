using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberMate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string X = "12321";
            string Y = "42531";
            Console.WriteLine(solution.solution(X, Y));
        }
    }

    public class Solution
    {
        public string solution(string X, string Y)
        {
            string answer = "";

            StringBuilder sb = new StringBuilder();

            Dictionary<char, int> xDic = new Dictionary<char, int>();
            Dictionary<char, int> yDic = new Dictionary<char, int>();

            foreach (char c in X) 
            {
                if (!xDic.ContainsKey(c))
                {
                    xDic.Add(c, 1);
                }
                else
                {
                    xDic[c] += 1;
                }
            }

            foreach (char c in Y)
            {
                if (!yDic.ContainsKey(c))
                {
                    yDic.Add(c, 1);
                }
                else
                {
                    yDic[c] += 1;
                }
            }

            for(int i = 9; i >= 0; i--)
            {
                char num = char.Parse(i.ToString());
                if (xDic.ContainsKey(num) && yDic.ContainsKey(num))
                {
                    int appendNum = xDic[num] > yDic[num] ? yDic[num] : xDic[num];
                    for (int j = 0; j < appendNum; ++j) sb.Append(num);
                }
            }

            answer = sb.ToString();
            if (answer == "") answer = "-1";
            if (answer.All(c => c == '0'))
            {
                answer = "0";
            }

            return answer;
        }
    }
}
