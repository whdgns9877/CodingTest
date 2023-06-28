using System;

namespace ConvertStringToInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution("1234"));
        }
    }

    public class Solution
    {
        public int solution(string s)
        {
            return int.Parse(s);
        }
    }
}
