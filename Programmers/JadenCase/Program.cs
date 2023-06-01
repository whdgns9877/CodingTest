using System.Globalization;

namespace JadenCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string s = "3people unFollowed me";
            solution.solution(s);
        }
    }

    public class Solution
    {
        public string solution(string s)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            string[] words = s.ToLower().Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrEmpty(words[i]))
                {
                    if (char.IsDigit(words[i][0]) && words[i].Length > 1)
                    {
                        words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
                    }
                    else
                    {
                        words[i] = textInfo.ToTitleCase(words[i]);
                    }
                }
            }

            string answer = string.Join(" ", words);
            return answer;
        }
    }
}