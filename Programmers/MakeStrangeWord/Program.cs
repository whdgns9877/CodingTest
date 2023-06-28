using System;

namespace MakeStrangeWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(" try hello world "));
        }
    }

    public class Solution
    {
        public string solution(string s)
        {
            int idx = 0;

            for (int i = 0; i < s.Length; i++)
            {

                if (s[i] == ' ')
                {
                    idx = 0;
                    continue;
                }

                if (idx % 2 == 1)
                {
                    if (Char.IsUpper(s[i])) s = s.Substring(0, i) + Char.ToLower(s[i]) + s.Substring(i + 1);
                }
                else
                {
                    if (Char.IsLower(s[i])) s = s.Substring(0, i) + Char.ToUpper(s[i]) + s.Substring(i + 1);
                }
                idx++;
            }

            return s;
        }
    }
}
