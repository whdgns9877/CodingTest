using System.Linq;

namespace PasswordForTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string s = "klmnopqrstuvwxyz";
            string skip = "abcdefghij";
            solution.solution(s, skip, 20);
        }
    }

    public class Solution
    {
        public string solution(string s, string skip, int index)
        {
            string answer = "";

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                for (int j = 0; j < index; j++)
                {
                    c += (char)1;
                    if (c > 'z')
                    {
                        c -= (char)26;
                    }
                    if (skip.Contains(c))
                    {
                        j--;
                    }
                }
                answer += c;
            }

            return answer;
        }
    }
}
