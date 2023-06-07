using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerPairsBetweenTwoCircles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(4, 10));
        }
    }

    public class Solution
    {
        public long solution(int r1, int r2)
        {
            long answer = 0;

            long r1x = (long)Math.Pow(r1, 2);
            long r2x = (long)Math.Pow(r2, 2);

            long side = 0;

            for (long i = 0; i <= r2; i++)
            {
                long y2 = (long)Math.Sqrt(r2x - (long)Math.Pow(i, 2));
                long y1 = (long)Math.Sqrt(r1x - (long)Math.Pow(i, 2));

                if (Math.Sqrt((r1x - Math.Pow(i, 2))) % 1 == 0)
                {
                    side++;
                }

                answer += (y2 - y1) * 4;
            }

            answer += side * 4 - 4;

            return answer;
        }
    }

}
