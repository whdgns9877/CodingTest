using System;
using System.Linq;

namespace MaxValAndMinVal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string s = "1 2 3 4";
            Console.WriteLine(solution.solution(s));
        }
    }

    public class Solution
    {
        public string solution(string s)
        {
            string[] numStrs = s.Split(' ');
            int[] nums = Array.ConvertAll(numStrs, Convert.ToInt32);
            string answer =  $"{nums.Min()} {nums.Max()}";
            return answer;
        }
    }
}
