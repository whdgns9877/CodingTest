using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDivisors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(12));
        }
    }

    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;

            for(int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    answer += i;
                }
            }

            return answer;
        }
    }
}
