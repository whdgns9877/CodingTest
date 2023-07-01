using System;

namespace CorrectBracket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string s = "()()";
            Console.WriteLine(solution.solution(s));
        }
    }

    public class Solution
    {
        public bool solution(string s)
        {
            bool answer = true;

            // 기준점을 세울 int변수
            int count = 0;

            if (s[0] == ')')
            {
                return false;
            }
            
            foreach (var p in s)
            {
                // 왼쪽괄호면 +
                if (p == '(')
                {
                    count++;
                }
                // 오른쪽 괄호면 -
                else
                {
                    // 오른쪽이 나왔는데 앞에 count된것이 없다면 '('가 없던것이므로 false 반환
                    if (count == 0)
                    {
                        return false;
                    }
                    count--;
                }
            }

            // 위의 검사를 끝낸후에 count가 남아잇다면 '(' 갯수가 더 많은것
            if (count > 0)
            {
                return false;
            }

            return answer;
        }
    }
}
