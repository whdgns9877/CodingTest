using System;
using System.Collections.Generic;

namespace RepeatBinaryConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string s = "110010101001";
            Console.WriteLine(solution.solution(s));
        }
    }

    public class Solution
    {
        public int[] solution(string s)
        {
            int[] answer = new int[] { 0, 0 };
            List<char> curStr = new List<char>(s);

            while (curStr.Count > 1)
            {
                for (int i = 0; i < curStr.Count;)
                {
                    if (curStr[i] == '0')
                    {
                        answer[1] += 1;
                        curStr.RemoveAt(i);
                    }
                    else
                    {
                        i++;
                    }
                }
                answer[0] += 1;

                int toDigit = curStr.Count;
                string numToDigit = Convert.ToString(toDigit, 2);
                curStr.Clear();
                curStr = new List<char>(numToDigit);
            }

            return answer;
        }
    }
}
