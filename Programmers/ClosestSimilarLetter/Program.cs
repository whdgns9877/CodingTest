using System.Collections.Generic;

namespace ClosestSimilarLetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string s = "banana";
            solution.solution(s);
        }
    }

    public class Solution
    {
        public int[] solution(string s)
        {
            int[] answer = new int[s.Length];
            int idx = 0;
            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach (char c in s) 
            {
                if (dic.ContainsKey(c))
                {
                    answer[idx] = idx - dic[c];
                    dic[c] = idx;
                }
                else
                {
                    dic.Add(c, idx);
                    answer[idx] = -1;
                }
                idx++;
            }

            return answer;
        }
    }
}
