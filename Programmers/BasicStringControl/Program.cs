using System;

namespace BasicStringControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution("121212"));
        }
    }

    public class Solution
    {
        public bool solution(string s)
        {
            if(s.Length == 4 ||  s.Length == 6)
            {
                int result = int.MaxValue;
                return int.TryParse(s, out result);
            }
            else
            {
                return false;
            }
        }
    }
}
