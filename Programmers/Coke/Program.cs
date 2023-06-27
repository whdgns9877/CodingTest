using System;

namespace Coke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(5, 3, 21));
        }
    }

    public class Solution
    {
        // a개를 가져다주면 b개를 받을수 있고 n개의 빈병 보유중
        public int solution(int a, int b, int n)
        {
            int answer = 0;
            int curCoke = n;

            while (curCoke >= a)
            {
                int curGetCoke = (curCoke / a) * b;
                curCoke =  curCoke -(a * (curCoke / a)) + curGetCoke; 
                answer += curGetCoke;
            }

            return answer;
        }
    }
}
