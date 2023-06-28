using System;

namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution("a B z", 4));
        }
    }

    public class Solution
    {
        public string solution(string s, int n)
        {
            char[] sToCharArr = s.ToCharArray();

            int z = 'z';

            for(int i = 0; i < sToCharArr.Length; i++)
            {
                if (sToCharArr[i] != ' ')
                {
                    // 대문자일때 처리
                    if (s[i] >= 97)
                    {
                        sToCharArr[i] = (char)(s[i] + n) > 122 ? (char)(s[i] + n - 26) : (char)(s[i] + n);
                    }
                    // 소문자일때 처리
                    else
                    {
                        sToCharArr[i] = (char)(s[i] + n) > 96 ? (char)(s[i] + n - 26) : (char)(s[i] + n);
                    }
                }
            }

            return new string(sToCharArr);
        }
    }
}
