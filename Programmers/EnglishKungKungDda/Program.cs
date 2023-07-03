using System;
using System.Collections.Generic;
using System.Linq;

namespace EnglishKungKungDda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] words = { "hello", "one", "even", "never", "now", "world", "draw" };
            Console.WriteLine(solution.solution(2, words)[0] + " " + solution.solution(2, words)[1]);
        }
    }

    class Solution
    {
        public int[] solution(int n, string[] words)
        {
            int[] answer = new int[2];

            Dictionary<string, int> wordDic = new Dictionary<string, int>();

            int curOrder = 1;
            int cycle = 1;

            for(int i = 0; i < words.Length; i++)
            {
                if(i == 0)
                {
                    wordDic.Add(words[0], curOrder);
                    curOrder++;
                    continue;
                }

                if (words[i][0] != words[i - 1].Last())
                {
                    answer[0] = curOrder;
                    answer[1] = cycle;
                    break;
                }

                if (!wordDic.ContainsKey(words[i]))
                {
                    wordDic.Add(words[i], curOrder);
                }
                else
                {
                    answer[0] = curOrder;
                    answer[1] = cycle;
                    break;
                }

                if(curOrder + 1 > n)
                {
                    curOrder = 1;
                    cycle++;
                }
                else
                {
                    curOrder++;
                }
            }
            return answer;
        }
    }
}
