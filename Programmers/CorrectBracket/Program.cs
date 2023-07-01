using System;

namespace CorrectBracket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string s = "())(()";
            Console.WriteLine(solution.solution(s));
        }
    }

    public class Solution
    {
        public bool solution(string s)
        {
            // 닫힌채로 시작하면 맞출수 없다 || 인덱스 개수가 홀수라면 짝을 맞출수 없다
            if (s[0] != '(' || s.Length % 2 == 1) 
            {
                return false;
            }

            int leftCount = 0;

            for(int i = 0; i < s.Length; i++)
            {
                // '(' 모양이 나오고나서 몇개가 나오는지 세놓는다
                if (s[i].Equals('('))
                {
                    leftCount++;
                }
                // ')' 모양이 나오고나서
                else
                {
                    // 그 뒤 엔덱스들이 leftCount 만큼 ')' 모양인지 확인한다
                    for(int j = leftCount; j < i + leftCount; j++)
                    {
                        // 중간에 '(' 모양이 들어가있다면 짝은 맞지않는다
                        if(s[j].Equals('('))
                        {
                            return false;
                        }
                    }
                    i += leftCount + 1;
                    leftCount = 0;
                }
            }

            return true;
        }
    }
}
