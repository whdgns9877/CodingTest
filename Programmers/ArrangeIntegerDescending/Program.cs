using System;
using System.Text;

namespace ArrangeIntegerDescending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(118372));
        }
    }

    public class Solution
    {
        public long solution(long n)
        {
            char[] nToCharArr = n.ToString().ToCharArray();
            Array.Sort(nToCharArr, (x,y) => y.CompareTo(x));
            
            StringBuilder sb = new StringBuilder();
            foreach (char c in nToCharArr) 
            {
                sb.Append(c);
            }

            long answer = long.Parse(sb.ToString());
            return answer;
        }
    }
}
