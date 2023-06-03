using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindRemainderOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.solution(3);
        }
    }

    public class Solution
    {
        public int solution(int n)
        {
            int answer = 0;

            for(int i = 1; i < n; ++i)
            {
                if(n % i == 1)
                {
                    answer = i;
                    break;
                }
            }

            return answer;
        }
    }
}
