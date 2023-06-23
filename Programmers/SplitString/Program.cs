using System;

namespace SplitString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string s = "aaabbaccccabba";
            Console.WriteLine(solution.solution(s));
        }
    }

    public class Solution
    {
        public int solution(string s)
        {
            int answer = 0;
            int num = s.Length;
            int i, j;
            for (i = 0; i < num; i++)
            {
                int count_x = 0; // x의 개수
                int count_else = 0; // x가 아닌 글자의 개수
                int x = s[i]; // x는 남은 문자열의 첫 문자

                for (j = i; j < num; j++)
                {
                    if (s[j] == x) count_x++;
                    else count_else++;
                    if (count_x == count_else) break; // 두 횟수가 다른 경우 중간에 스탑
                }
                i = j; // 앞 부분(읽은 부분)은 잘라내고 뒷부분부터 검사
                answer++; // 한 번 잘라낼 때마다 카운트
            }

            return answer;
        }
    }
}
