using System;

namespace StringArrangeDescending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution("Zbcdefg"));
        }
    }

    public class Solution
    {
        public string solution(string s)
        {
            char[] chars = s.ToCharArray();
            Array.Sort(chars, (x,y) => y.CompareTo(x));
            return new string(chars);
        }
    }
}
