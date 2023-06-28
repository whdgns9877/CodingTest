using System;

namespace GetMidChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution("abcde"));
        }
    }

    public class Solution
    {
        public string solution(string s)
        {
            int middle = s.Length / 2; 
            if (s.Length % 2 == 0)
            {
                return s[middle - 1].ToString() + s[middle].ToString();
            }
            else
            {
                return s[middle].ToString();
            }
        }
    }
}
