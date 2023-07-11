using System;

namespace VowelDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string word = "I";
            Console.WriteLine(solution.solution(word));
        }
    }

    public class Solution
    {
        public int solution(string word)
        {
            int answer = 0;
            int[] li = { 781, 156, 31, 6, 1 };

            char[] vowels = { 'A', 'E', 'I', 'O', 'U' };

            for (int i = 0; i < word.Length; i++)
            {
                answer += li[i] * (Array.IndexOf(vowels, word[i]));
            }

            answer += word.Length;

            return answer;
        }
    }
}
