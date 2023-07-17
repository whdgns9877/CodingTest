using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MakeBig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string number = "4177252841";
            Console.WriteLine(solution.solution(number, 4));
        }
    }

    class Solution
    {
        public string solution(string number, int k)
        {
            int digitsToRemove = number.Length - k; // 제거해야 할 숫자 개수 계산
            char[] result = new char[digitsToRemove]; // 결과를 저장할 문자열 배열 생성
            int top = -1; // 스택의 top 인덱스
            for (int i = 0; i < number.Length; i++)
            {
                char digit = number[i];
                // 스택의 top에 있는 숫자보다 현재 숫자가 크면 top의 숫자를 제거
                while (top >= 0 && result[top] < digit && k > 0)
                {
                    top--;
                    k--;
                }
                // 숫자를 스택에 추가
                if (top < digitsToRemove - 1)
                {
                    result[++top] = digit;
                }
                else
                {
                    // 이미 필요한 숫자 개수를 모두 얻은 경우 나머지 숫자는 무시
                    break;
                }
            }
            return new string(result);
        }
    }
}
