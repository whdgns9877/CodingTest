using System;
using System.Collections.Generic;

namespace RotateBracket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string s = "}]()[{";
            Console.WriteLine(solution.solution(s));
        }
    }

    public class Solution
    {
        public int solution(string s)
        {
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>();
            bracketPairs.Add(']', '[');
            bracketPairs.Add(')', '(');
            bracketPairs.Add('}', '{');

            int answer = 0;

            for (int i = 0; i < s.Length; i++)
            {
                string rotated = RotateString(s, i);
                if (IsCorrectBracket(rotated, bracketPairs))
                {
                    answer++;
                }
            }

            return answer;
        }

        private string RotateString(string s, int x)
        {
            x %= s.Length;
            string rotated = s.Substring(x) + s.Substring(0, x);
            return rotated;
        }

        private bool IsCorrectBracket(string s, Dictionary<char, char> bracketPairs)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (bracketPairs.ContainsValue(c))
                {
                    stack.Push(c);
                }
                else if (bracketPairs.ContainsKey(c))
                {
                    if (stack.Count == 0 || bracketPairs[c] != stack.Pop())
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
