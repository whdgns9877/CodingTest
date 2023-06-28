using System;
using System.Text;

namespace RepeatChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(7));
        }
    }

    public class Solution
    {
        public string solution(int n)
        {
            const string SU = "수";
            const string BAK = "박";
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                sb.Append(i % 2 == 0 ? SU : BAK);
            }

            return sb.ToString();
        }
    }
}
