using System;
using System.Collections.Generic;
using System.Linq;

namespace RoughKeyBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] keymap = { "AGZ", "BSSS" };
            string[] targets = { "ASA", "BGZ" };
            int[] result = solution.solution(keymap, targets);

            foreach (int count in result)
            {
                Console.WriteLine(count);
            }
        }
    }

    public class Solution
    {
        public int[] solution(string[] keymap, string[] targets)
        {
            int[] answer = new int[targets.Length];
            Dictionary<char, int> keyValDic = CreateKeyValDictionary(keymap);

            for (int i = 0; i < targets.Length; ++i)
            {
                int targetCount = CalculateTargetCount(targets[i], keyValDic);
                answer[i] = targetCount;
            }

            return answer;
        }

        private Dictionary<char, int> CreateKeyValDictionary(string[] keymap)
        {
            Dictionary<char, int> keyValDic = new Dictionary<char, int>();

            foreach (string key in keymap)
            {
                // 중복 제거를 위해 HashSet사용
                HashSet<char> keyChars = new HashSet<char>(key);
                foreach (char c in keyChars)
                {
                    int idx = Array.IndexOf(key.ToCharArray(), c);
                    if (!keyValDic.ContainsKey(c) || (idx != -1 && idx + 1 < keyValDic[c]))
                    {
                        keyValDic[c] = idx + 1;
                    }
                }
            }

            return keyValDic;
        }

        private int CalculateTargetCount(string target, Dictionary<char, int> keyValDic)
        {
            int count = 0;
            foreach (char c in target)
            {
                if (!keyValDic.ContainsKey(c) || keyValDic[c] == -1)
                {
                    count = -1;
                    break;
                }
                count += keyValDic[c];
            }
            return count;
        }
    }

}
