using System;

namespace AddDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(987));
        }
    }


    public class Solution
    {
        public int solution(int n)
        {
            string s = n.ToString();
            int answer = 0;

            foreach (char digit in s)
            {
                answer += int.Parse(digit.ToString());
            }

            return answer;
        }
    }
}
